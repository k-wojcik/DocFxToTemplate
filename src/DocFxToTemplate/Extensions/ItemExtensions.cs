using DocFxToTemplate.Models.DocFx;

namespace DocFxToTemplate.Extensions;

internal static class ItemExtensions
{
    public static IEnumerable<ItemViewModel> GetProperties(this IEnumerable<ItemViewModel> items, string uid)
        => items
            .Where(i => i.Parent == uid && i.Type == MemberType.Property)
            .OrderBy(x => x.Name)
            .ThenBy(x => x.Uid);

    public static IEnumerable<ItemViewModel> GetFields(this IEnumerable<ItemViewModel> items, string uid)
        => items
            .Where(i => i.Parent == uid && i.Type == MemberType.Field)
            .OrderBy(x => x.Name)
            .ThenBy(x => x.Uid);

    public static IEnumerable<ItemViewModel> GetMethods(this IEnumerable<ItemViewModel> items, string uid)
        => items
            .Where(i => i.Parent == uid && i.Type == MemberType.Method)
            .OrderBy(x => x.Name)
            .ThenBy(x => x.Uid);

    public static IEnumerable<ItemViewModel> GetEvents(this IEnumerable<ItemViewModel> items, string uid)
        => items
            .Where(i => i.Parent == uid && i.Type == MemberType.Event)
            .OrderBy(x => x.Name)
            .ThenBy(x => x.Uid);

    public static ItemViewModel? GetByUid(this IEnumerable<ItemViewModel> items, string uid)
        => items.SingleOrDefault(i => i.Uid == uid);

    public static ReferenceViewModel? GetByUid(this IEnumerable<ReferenceViewModel> items, string uid)
        => items.SingleOrDefault(i => i.Uid == uid);

    public static List<ReferenceViewModel> GetByUid(this IEnumerable<ReferenceViewModel> items, List<string>? uids)
        => uids?
               .Select(uid => items.SingleOrDefault(i => i.Uid == uid))
               .Where(x => x != null)
               .Select(x => x!)
               .OrderBy(x => x.Name)
               .ThenBy(x => x.Uid)
               .ToList()
           ?? new List<ReferenceViewModel>(0);
}