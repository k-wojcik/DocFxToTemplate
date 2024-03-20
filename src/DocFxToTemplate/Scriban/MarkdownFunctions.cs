using Docfx.Common.Git;
using DocFxToTemplate.Blocks;
using DocFxToTemplate.Extensions;
using DocFxToTemplate.Models.DocFx;
using Scriban;

namespace DocFxToTemplate.Scriban;

// ReSharper disable MemberCanBePrivate.Global
internal static class MarkdownFunctions
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

    public static string? Source_Repo_RawLink(this SourceDetail? source)
    {
        if (source?.Remote is null)
        {
            return null;
        }

        var gitSource = new GitSource(
            source.Remote.Repo, 
            source.Remote.Branch, 
            source.Remote.Path,
            source.StartLine + 1);
        return GitUtility.GetSourceUrl(gitSource);
    }
    
    public static string? Source_Repo_Link(this SourceDetail? source)
    {
        if (source?.Remote is null)
        {
            return null;
        }

        var rawLink = Source_Repo_RawLink(source);
        return $"[{source.Remote.Path}#L{source.StartLine + 1}]({rawLink})";
    }
    
    public static string? Summary(TemplateContext context, string? summary) =>
        SummaryFunction.Summary(context, summary);
}