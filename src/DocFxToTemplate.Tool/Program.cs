using System.ComponentModel.DataAnnotations;
using Docfx.Dotnet;
using DocFxToTemplate;
using McMaster.Extensions.CommandLineUtils;
using McMaster.Extensions.CommandLineUtils.Validation;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

var app = new CommandLineApplication();
app.HelpOption();

app.Command("build", cmd =>
{
    var yamlDirectory = cmd.Option("-y|--yaml <DIRECTORY>",
        "The DocFx yaml directory",
        CommandOptionType.SingleValue);

    var docFxConfig = cmd.Option("-c|--config <CONFIG>",
        "The docfx.json config file",
        CommandOptionType.SingleValue);

    var outputDirectory = cmd.Option("-o|--output <DIRECTORY>",
        "The output directory",
        CommandOptionType.SingleValue,
        x => x.IsRequired());

    var skipDocFxGenerate = cmd.Argument("-s|--skip-docfx",
        "Skips docfx YAML metadata generation");

    cmd.Validators.Add(new DelegateValidator(x =>
    {
        if (!yamlDirectory.HasValue() && !docFxConfig.HasValue())
        {
            return new ValidationResult("One of the --yaml or --config options is required!");
        }

        return ValidationResult.Success!;
    }));

    cmd.OnExecuteAsync(async _ =>
    {
        if (!skipDocFxGenerate.HasValue)
        {
            await DotnetApiCatalog.GenerateManagedReferenceYamlFiles(docFxConfig.Value(), new DotnetApiOptions());
        }
        
        var source = GetSource(yamlDirectory, docFxConfig);
        using var factory = LoggerFactory.Create(builder => builder.AddConsole());
        var options = new GeneratorOptions()
        {
            YamlPath = source,
            OutputPath = outputDirectory.Value()!
        };

        var generator = new Generator(factory.CreateLogger<Generator>(), options);
        await generator.Generate();
    });
});

return app.Execute(args);

static string GetSource(CommandOption yamlDirectory, CommandOption docFxConfig)
{
    if (yamlDirectory.HasValue())
    {
         return yamlDirectory.Value()!;
    }

    if (docFxConfig.HasValue())
    {
        var config = JObject.Parse(File.ReadAllText(docFxConfig.Value()!));

        if (config.TryGetValue("metadata", out var metadata))
        {
            var destination = metadata.FirstOrDefault()?["dest"]?.Value<string>();
            if (destination != null)
            {
                if (Path.IsPathRooted(destination))
                {
                    return destination;
                }
                
                return Path.Combine(Path.GetDirectoryName(docFxConfig.Value()!)!, destination);
            }
        }
    }

    throw new ArgumentException("Docfx YAML metadata directory cannot be determined!");
}