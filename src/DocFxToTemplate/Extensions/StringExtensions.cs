using System.Diagnostics.CodeAnalysis;
using MemberType = DocFxToTemplate.Models.DocFx.MemberType;

namespace DocFxToTemplate.Extensions;

internal static class StringExtensions
{
    [return: NotNullIfNotNull(nameof(str))]
    public static string? HtmlEscape(this string? str)
        => str?
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("}", "\\>")
            .Replace("{", "\\<");

    public static string? FileEscape(this string? str)
        => str?.Replace("<", "`").Replace(">", "`").Replace(" ", "%20");

    [return: NotNullIfNotNull(nameof(str))]
    public static string? GetMarkdownHash(this string? str)
        => str?.ToLower()
            .Replace("(", "")
            .Replace(")", "")
            .Replace("?", "");
    
    public static string GetTypePathPart(this MemberType? type)
        => type switch
        {
            MemberType.Class => "Classes",
            MemberType.Struct => "Structs",
            MemberType.Interface => "Interfaces",
            MemberType.Enum => "Enums",
            MemberType.Delegate => "Delegates",
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null),
        };
}