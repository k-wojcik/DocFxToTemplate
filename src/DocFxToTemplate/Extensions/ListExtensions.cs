namespace DocFxToTemplate.Extensions;

internal static class ListExtensions
{
    public static List<T>? OrderBy<T>(this List<T>? input) => input?.OrderBy(x=> x).ToList();
}