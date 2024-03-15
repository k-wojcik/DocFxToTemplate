using DocFxToTemplate.Blocks;
using DocFxToTemplate.Extensions;
using DocFxToTemplate.Models.DocFx;
using Scriban;

namespace DocFxToTemplate.Scriban;

internal static class MakrdownFunctions
{
    public static string? Escape(string? input) => input.HtmlEscape();

    public static string? Abs_Link(MarkdownLink? input) =>
        input != null
            ? $"[{input.Name.HtmlEscape()}]({input.AbsoluteAddress})"
            : string.Empty;

    public static string? Ref_Link(TemplateContext context, ReferenceViewModel? input)
    {
        if (input == null)
        {
            return string.Empty;
        }

        if (input.Item != null)
        {
            var generatorContext = context.GetGeneratorContext();
            var link = input.Item.GetLink(generatorContext.Items);
            return $"[{input.NameWithType.HtmlEscape()}]({link?.AbsoluteAddress})";
        }
        
        if (input.IsExternal == true && !string.IsNullOrWhiteSpace(input.Href))
        {
            return $"[{input.NameWithType.HtmlEscape()}]({input.Href})";
        }
        
        return input.NameWithType.HtmlEscape();
    }
    
    public static string? Item_Link(TemplateContext context, ItemViewModel? input)
    {
        if (input == null)
        {
            return string.Empty;
        }
        
        var generatorContext = context.GetGeneratorContext();
        var link = input.GetLink(generatorContext.Items);
        return $"[{StringExtensions.HtmlEscape(input.NameWithType)}]({link?.AbsoluteAddress})";
    }
    
    public static string? Item_Source_Link(this ItemViewModel item)
        => item.Source?.Remote != null
            ? $"[{item.Source.Path}]({item.Source.Remote.Repo}/blob/{item.Source.Remote.Branch}/{item.Source.Remote.Path}#L{item.Source.StartLine + 1})"
            : null;
    
    public static string? Summary(TemplateContext context, string? summary) =>
        SummaryFunction.Summary(context, summary);
}