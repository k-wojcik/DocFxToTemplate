using DocFxToTemplate.Extensions;
using DocFxToTemplate.Models.DocFx;

namespace DocFxToTemplate.Blocks;

internal static class Link
{
      public static MarkdownLink? GetLink(this List<ItemViewModel> items, string uid)
      {
          var item = items.SingleOrDefault(x => x.Uid == uid);
          if (item == null)
          {
              return null;
          }
          
          return item.GetLink(items);
      }
      
      public static MarkdownLink? GetLink(this ItemViewModel item, List<ItemViewModel> items)
      {
          var linkFromIndex = false;
          var linkFromGroupedType = false;
          var dots = linkFromIndex ? "./" : linkFromGroupedType ? "../../" : "../";
          
          string name = item.NameWithType.HtmlEscape();
          var extension = linkFromIndex ? ".md" : "";

          string? absoluteAddress = null;
          if (item.Type is MemberType.Class or MemberType.Interface or MemberType.Enum or MemberType.Struct or MemberType.Delegate)
          {
              absoluteAddress = $"{dots}{item.NamespaceName}/{item.Name}{extension}".FileEscape();
          }
          else if (item.Type is MemberType.Namespace)
          {
              absoluteAddress = $"{item.Name.HtmlEscape()}/{item.Name.HtmlEscape()}.md".FileEscape();
          }
          else
          {
              var parent = items.FirstOrDefault(i => i.Uid == item.Parent);
              if (parent != null)
              {
                  var urlPart = $"{dots}{item.NamespaceName}/{parent.Name}{extension}".FileEscape();
                  var hashPart = $"#{item.Name.GetMarkdownHash()}";
                    absoluteAddress = $"{urlPart}{hashPart}";

              }
          }

          return new(name, absoluteAddress);
      }
}