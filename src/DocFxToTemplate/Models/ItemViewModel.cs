using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using DocFxToTemplate.Models.DocFx;
using YamlDotNet.Serialization;

// ReSharper disable once CheckNamespace
namespace DocFxToTemplate.Models.DocFx;

public partial class ItemViewModel
{
    
    [JsonIgnore]
    [YamlIgnore]
    [IgnoreDataMember]
    public ItemViewModel[] Properties { get; set; }
    
    [JsonIgnore]
    [YamlIgnore]
    [IgnoreDataMember]
    public ItemViewModel[] Fields { get; set; }
    
    [JsonIgnore]
    [YamlIgnore]
    [IgnoreDataMember]
    public ItemViewModel[] Methods { get; set; }
    
    [JsonIgnore]
    [YamlIgnore]
    [IgnoreDataMember]
    public ItemViewModel[] Events { get; set; }
    
    [JsonIgnore]
    [YamlIgnore]
    [IgnoreDataMember]
    public List<ReferenceViewModel> InheritanceRefs { get; set; }

    [JsonIgnore]
    [YamlIgnore]
    [IgnoreDataMember]
    public List<ReferenceViewModel> DerivedClassesRefs { get; set; }
    
    [JsonIgnore]
    [YamlIgnore]
    [IgnoreDataMember]
    public List<ReferenceViewModel> ImplementsRefs { get; set; }
    
    [JsonIgnore]
    [YamlIgnore]
    [IgnoreDataMember]
    public List<ReferenceViewModel> InheritedMembersRefs { get; set; }
    
    [JsonIgnore]
    [YamlIgnore]
    [IgnoreDataMember]
    public List<ReferenceViewModel> ExtensionMethodsRefs { get; set; }
    
    
    [JsonIgnore]
    [YamlIgnore]
    [IgnoreDataMember]
    public MarkdownLink? Link { get; set; }
}

public record MarkdownLink(string Name, string? AbsoluteAddress);