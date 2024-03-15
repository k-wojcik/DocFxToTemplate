using System.Text.RegularExpressions;
using DocFxToTemplate.Blocks;
using DocFxToTemplate.Extensions;
using Scriban;

namespace DocFxToTemplate.Scriban;

internal static class SummaryFunction
{
    private static readonly Regex XrefRegex =
        new("<xref href=\"(.+?)\" data-throw-if-not-resolved=\"false\"></xref>", RegexOptions.Compiled);
    
    private static readonly Regex LangwordXrefRegex =
        new("<xref uid=\"langword_csharp_.+?\" name=\"(.+?)\" href=\"\"></xref>", RegexOptions.Compiled);
    
    private static readonly Regex CodeBlockRegex =
        new("<pre><code class=\"lang-csharp\">((.|\n)+?)</code></pre>", RegexOptions.Compiled);
    
    private static readonly Regex CodeRegex = new("<code>(.+?)</code>", RegexOptions.Compiled);
    
    private static readonly Regex LinkRegex = new("<a href=\"(.+?)\">(.+?)</a>", RegexOptions.Compiled);
    
    private static readonly Regex BrRegex = new("<br */?>", RegexOptions.Compiled);
    
    public static string Summary(TemplateContext context, string? summary)
    {
        if (summary == null)
        {
            return string.Empty;
        }
        
        summary = XrefRegex.Replace(summary, match =>
        {
            var generatorContext = context.GetGeneratorContext();
            var uid = match.Groups[1].Value;
            var link = generatorContext.Items.GetLink(uid);
            if (link == null)
            {
                return uid;
            }
            
            return $"[{link.Name}]({link.AbsoluteAddress})";
        });
        summary = LangwordXrefRegex.Replace(summary, match => $"`{match.Groups[1].Value}`");
        summary = CodeBlockRegex.Replace(summary, match => $"```csharp\n{match.Groups[1].Value.Trim()}\n```");
        summary = CodeRegex.Replace(summary, match => $"`{match.Groups[1].Value}`");
        summary = LinkRegex.Replace(summary, match => $"[{match.Groups[2].Value}]({match.Groups[1].Value})");
        summary = BrRegex.Replace(summary, _ => "\r\n");
        
        return summary.HtmlEscape();
    }
}