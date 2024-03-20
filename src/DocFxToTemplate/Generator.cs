using System.Diagnostics;
using System.Reflection;
using DocFxToTemplate.Blocks;
using DocFxToTemplate.Extensions;
using DocFxToTemplate.Models.DocFx;
using DocFxToTemplate.Templates;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using Scriban;
using Scriban.Runtime;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace DocFxToTemplate;

public sealed class Generator
{
    private readonly ILogger<Generator> _logger;
    private readonly GeneratorOptions _options;

    public Generator(ILogger<Generator> logger, GeneratorOptions options)
    {
        _logger = logger;
        _options = options;
    }

    public async Task Generate()
    {
        LogVersion();
        CheckInput();
        PrePareOutputDirectory();
        var items = await GetItems();
        FillItemReferences(items.Items, items.References);
        ProcessNamespaces(items.Items);

        _logger.LogInformation("Generating and writing markdown...");

        var context = new GeneratorContext()
        {
            Items = items.Items
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Uid)
                .ToList(),
            Options = _options,
        };

        await ProcessFiles(context);
        await GenerateIndex(context);

        _logger.LogInformation($"Markdown finished in ms.");
    }

    private void LogVersion()
    {
        var versionString = Assembly.GetEntryAssembly()?
            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
            .InformationalVersion ?? Assembly.GetExecutingAssembly().GetName().Version?.ToString();
        _logger.LogDebug($"DocFxToTemplate v{versionString} running...");
    }

    private void CheckInput()
    {
        ArgumentNullException.ThrowIfNull(_options.OutputPath);
        ArgumentNullException.ThrowIfNull(_options.YamlPath);
        if (!Directory.Exists(_options.YamlPath))
        {
            throw new InvalidOperationException($"Path '{_options.YamlPath}' does not exist");
        }
    }

    private void PrePareOutputDirectory()
    {
        if (Directory.Exists(_options.OutputPath) && Directory.EnumerateFiles(_options.OutputPath).Any())
        {
            if (File.Exists(Path.Combine(_options.OutputPath, "index.md")))
            {
                Directory.Delete(_options.OutputPath, true);
            }
            else
            {
                throw new InvalidOperationException("Failed to delete the output directory. " +
                                                    "The folder exists but does not contain the expected files.");
            }
        }

        Directory.CreateDirectory(_options.OutputPath);
    }

    private class DeserializerPooledObjectPolicy : PooledObjectPolicy<IDeserializer>
    {
        public override IDeserializer Create() =>
            new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .IgnoreUnmatchedProperties()
                .Build();

        public override bool Return(IDeserializer obj) => true;
    }

    private async Task<(List<ItemViewModel> Items, List<ReferenceViewModel> References)> GetItems()
    {
        List<ItemViewModel> items = new();
        List<ReferenceViewModel> references = new();
        var stopwatch = Stopwatch.StartNew();
        var provider = new DefaultObjectPoolProvider();
        var pool = provider.Create(new DeserializerPooledObjectPolicy());

        await Parallel.ForEachAsync(Directory.GetFiles(_options.YamlPath, "*.yml"), async (file, cancellationToken) =>
        {
            if (file.EndsWith("toc.yml"))
            {
                return;
            }

            _logger.LogDebug(file);
            var yamlDeserializer = pool.Get();

            try
            {
                var content = await File.ReadAllTextAsync(file, cancellationToken);
                var obj = yamlDeserializer.Deserialize<PageViewModel>(content);

                foreach (var item in obj.Items)
                {
                    PrepareItem(item);
                }

                lock (items)
                {
                    items.AddRange(obj.Items);
                    references.AddRange(obj.References);
                }
            }
            finally
            {
                pool.Return(yamlDeserializer);
            }
        });
        _logger.LogInformation($"Read all YAML in {stopwatch.ElapsedMilliseconds}ms.");

        references = references
            .GroupBy(x => x.Uid)
            .Select(x => x.First())
            .ToList();

        return (items, references);
    }

    private void PrepareItem(ItemViewModel itemViewModel)
    {
        itemViewModel.Children = itemViewModel.Children.OrderBy();
        itemViewModel.DerivedClasses = itemViewModel.DerivedClasses.OrderBy();
        itemViewModel.AssemblyNameList = itemViewModel.AssemblyNameList.OrderBy();
        itemViewModel.Examples = itemViewModel.Examples.OrderBy();
        itemViewModel.Inheritance = itemViewModel.Inheritance.OrderBy();
        itemViewModel.Implements = itemViewModel.Implements.OrderBy();
        itemViewModel.InheritedMembers = itemViewModel.InheritedMembers.OrderBy();
        itemViewModel.ExtensionMethods = itemViewModel.ExtensionMethods.OrderBy();
        itemViewModel.Platform = itemViewModel.Platform.OrderBy();
        itemViewModel.Exceptions = itemViewModel.Exceptions?
            .OrderBy(x => x.CommentId)
            .ToList();
        itemViewModel.SeeAlsos = itemViewModel.SeeAlsos?
            .OrderBy(x => x.LinkId)
            .ToList();
        itemViewModel.Attributes = itemViewModel.Attributes?
            .OrderBy(x => x.Constructor)
            .ThenBy(x => x.Arguments.Count)
            .ToList();
    }

    private void FillItemReferences(List<ItemViewModel> items, List<ReferenceViewModel> references)
    {
        foreach (var reference in references)
        {
            reference.Item = items.GetByUid(reference.Uid);
            reference.SpecCsharp.ForEach(x => x.Item = items.GetByUid(x.Uid));
        }

        foreach (var itemViewModel in items)
        {
            if (!string.IsNullOrWhiteSpace(itemViewModel.Uid))
            {
                itemViewModel.Properties = items.GetProperties(itemViewModel.Uid).ToArray();
                itemViewModel.Fields = items.GetFields(itemViewModel.Uid).ToArray();
                itemViewModel.Methods = items.GetMethods(itemViewModel.Uid).ToArray();
                itemViewModel.Events = items.GetEvents(itemViewModel.Uid).ToArray();
                itemViewModel.Link = items.GetLink(itemViewModel.Uid);
            }

            itemViewModel.InheritanceRefs = references.GetByUid(itemViewModel.Inheritance);
            itemViewModel.DerivedClassesRefs = references.GetByUid(itemViewModel.DerivedClasses);
            itemViewModel.ImplementsRefs = references.GetByUid(itemViewModel.Implements);
            itemViewModel.InheritedMembersRefs = references.GetByUid(itemViewModel.InheritedMembers);
            itemViewModel.ExtensionMethodsRefs = references.GetByUid(itemViewModel.ExtensionMethods);

            if (itemViewModel.Syntax != null)
            {
                itemViewModel.Syntax.Parameters?.ForEach(p => p.Reference = references.GetByUid(p.Type));
                itemViewModel.Syntax.TypeParameters?.ForEach(p => p.Reference = references.GetByUid(p.Type));
                if (itemViewModel.Syntax.Return != null)
                {
                    itemViewModel.Syntax.Return.Reference = references.GetByUid(itemViewModel.Syntax.Return.Type);
                }
            }
        }
    }

    private void ProcessNamespaces(List<ItemViewModel> items)
    {
        Parallel.ForEach(items, (item, _) =>
        {
            if (item.Type == MemberType.Namespace)
            {
                _logger.LogDebug(item.Type + ": " + item.Name);
                var dir = Path.Combine(_options.OutputPath, item.Name);
                Directory.CreateDirectory(dir);
            }
        });
    }

    private async Task ProcessFiles(GeneratorContext context)
    {
        await Parallel.ForEachAsync(context.Items, async (item, cancellationToken) =>
        {
            if (item.CommentId == null)
            {
                if (item.Type == MemberType.Namespace)
                {
                    return;
                }

                _logger.LogWarning($"Missing commentId for {item.Uid ?? item.Id ?? "(can't get uid or id)"}");
                return;
            }

            if (item.CommentId.StartsWith("T:"))
            {
                var content = await Render(context, item, "Templates/class/index.tpl");
                await Save(item, context, content);
            }
            else if (item.Type == MemberType.Namespace)
            {
                var content = await Render(context, item, "Templates/namespace/index.tpl");
                await File.WriteAllTextAsync(
                    Path.Join(context.Options.OutputPath, (string?)item.Name, $"{item.Name}.md"), content,
                    cancellationToken);
            }
        });
    }

    private async Task Save(ItemViewModel item, GeneratorContext context, string content)
    {
        var path =
            $"{Path.Join(context.Options.OutputPath, (string?)item.NamespaceName, (string?)item.Name.Replace('<', '`').Replace('>', '`'))}.md";

        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        await File.WriteAllTextAsync(path, content);
    }

    private static async Task<string> Render<TModel>(GeneratorContext context, TModel model, string templatePath)
    {
        var tpl = new TemplateLoader();
        var scriptObject = new ScriptObject()
        {
            ["model"] = model,
            ["generator_context"] = context
        };

        if (model != null)
        {
            scriptObject.Import(model);
        }

        var templateContext = new TemplateContext()
        {
            TemplateLoader = tpl,
        };
        templateContext.PushGlobal(scriptObject);

        var functionsScriptObject = new ScriptObject();
        var functions = new ScriptObject();
        functions.Import(typeof(Scriban.MarkdownFunctions), null, x => x.Name.ToLower());
        functionsScriptObject.Add("md", functions);
        templateContext.PushGlobal(functionsScriptObject);

        var template = Template.Parse(await File.ReadAllTextAsync(templatePath));
        return await template.RenderAsync(templateContext);
    }

    private async Task GenerateIndex(GeneratorContext context)
    {
        var content = await Render(context, new { }, "Templates/index.tpl");
        await File.WriteAllTextAsync(Path.Join(_options.OutputPath, $"index.md"), content);
    }
}