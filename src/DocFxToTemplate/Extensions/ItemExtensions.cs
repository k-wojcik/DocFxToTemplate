using DocFxToTemplate.Models.DocFx;

namespace DocFxToTemplate.Extensions;

internal static class ItemExtensions
{
    public static IEnumerable<ItemViewModel> GetProperties(this IEnumerable<ItemViewModel> items, string uid)
        => items
            .Where(i => i.Parent == uid && i.Type == MemberType.Property)
            .OrderByDefault();

    public static IEnumerable<ItemViewModel> GetFields(this IEnumerable<ItemViewModel> items, string uid)
        => items
            .Where(i => i.Parent == uid && i.Type == MemberType.Field)
            .OrderByDefault();

    public static IEnumerable<ItemViewModel> GetMethods(this IEnumerable<ItemViewModel> items, string uid)
        => items
            .Where(i => i.Parent == uid && i.Type == MemberType.Method)
            .OrderByDefault();

    public static IEnumerable<ItemViewModel> GetEvents(this IEnumerable<ItemViewModel> items, string uid)
        => items
            .Where(i => i.Parent == uid && i.Type == MemberType.Event)
            .OrderByDefault();

    public static ItemViewModel? GetByUid(this IEnumerable<ItemViewModel> items, string uid)
        => items.SingleOrDefault(i => i.Uid == uid);

    public static ReferenceViewModel? GetByUid(this IEnumerable<ReferenceViewModel> items, string uid)
        => items.SingleOrDefault(i => i.Uid == uid);

    public static List<ReferenceViewModel> GetByUid(this IEnumerable<ReferenceViewModel> items, List<string>? uids)
        => uids?
               .Select(uid => items.SingleOrDefault(i => i.Uid == uid))
               .Where(x => x != null)
               .Select(x => x!)
               .ToList()
           ?? new List<ReferenceViewModel>(0);

    public static IEnumerable<ItemViewModel> OrderByDefault(this IEnumerable<ItemViewModel> items)
        => items
            .OrderBy(x => x.Source?.StartLine ?? int.MaxValue)
            .ThenBy(x => x.Name)
            .ThenBy(x => x.Uid);
    
}