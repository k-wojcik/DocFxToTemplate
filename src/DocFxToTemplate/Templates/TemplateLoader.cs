using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;

namespace DocFxToTemplate.Templates;

public class TemplateLoader : ITemplateLoader
{
    private string TemplatePath = "Templates";
    
    public string GetPath(TemplateContext context, SourceSpan callerSpan, string templateName)
    {
        return Path.Combine(Environment.CurrentDirectory, TemplatePath, templateName);
    }

    public string Load(TemplateContext context, SourceSpan callerSpan, string templatePath)
    {
        return File.ReadAllText(templatePath);
    }

    public async ValueTask<string> LoadAsync(TemplateContext context, SourceSpan callerSpan, string templatePath)
    {
        return await File.ReadAllTextAsync(templatePath);
    }
}