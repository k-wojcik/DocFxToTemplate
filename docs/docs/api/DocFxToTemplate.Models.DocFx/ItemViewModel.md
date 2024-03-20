---
title: Class ItemViewModel
sidebar_label: ItemViewModel
description: TODO
---

# Class ItemViewModel
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/ItemViewModel.cs#L9](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/ItemViewModel.cs#L9)    
   

```csharp title="src/DocFxToTemplate/Models/ItemViewModel.cs#L9" 
public class ItemViewModel
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Properties
   
            
```csharp title="src/DocFxToTemplate/Models/ItemViewModel.cs#L12"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public ItemViewModel[] Properties { get; set; }
```   

#### Property Value
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)[]   
   
### Uid
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L12"
[YamlMember(Alias = "uid")]
[JsonPropertyName("uid")]
[MergeOption(MergeOption.MergeKey)]
public string? Uid { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### CommentId
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L17"
[YamlMember(Alias = "commentId")]
[JsonPropertyName("commentId")]
public string? CommentId { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Fields
   
            
```csharp title="src/DocFxToTemplate/Models/ItemViewModel.cs#L17"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public ItemViewModel[] Fields { get; set; }
```   

#### Property Value
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)[]   
   
### Id
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L21"
[YamlMember(Alias = "id")]
[JsonPropertyName("id")]
public string? Id { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Methods
   
            
```csharp title="src/DocFxToTemplate/Models/ItemViewModel.cs#L22"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public ItemViewModel[] Methods { get; set; }
```   

#### Property Value
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)[]   
   
### IsExplicitInterfaceImplementation
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L25"
[YamlMember(Alias = "isEii")]
[JsonPropertyName("isEii")]
public bool IsExplicitInterfaceImplementation { get; set; }
```   

#### Property Value
[bool](https://learn.microsoft.com/dotnet/api/system.boolean)   
   
### Events
   
            
```csharp title="src/DocFxToTemplate/Models/ItemViewModel.cs#L27"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public ItemViewModel[] Events { get; set; }
```   

#### Property Value
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)[]   
   
### IsExtensionMethod
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L29"
[YamlMember(Alias = "isExtensionMethod")]
[JsonPropertyName("isExtensionMethod")]
public bool IsExtensionMethod { get; set; }
```   

#### Property Value
[bool](https://learn.microsoft.com/dotnet/api/system.boolean)   
   
### InheritanceRefs
   
            
```csharp title="src/DocFxToTemplate/Models/ItemViewModel.cs#L32"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public List<ReferenceViewModel> InheritanceRefs { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)&gt;   
   
### Parent
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L33"
[YamlMember(Alias = "parent")]
[JsonPropertyName("parent")]
public string Parent { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### DerivedClassesRefs
   
            
```csharp title="src/DocFxToTemplate/Models/ItemViewModel.cs#L37"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public List<ReferenceViewModel> DerivedClassesRefs { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)&gt;   
   
### Children
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L38"
[YamlMember(Alias = "children")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("children")]
public List<string>? Children { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### ImplementsRefs
   
            
```csharp title="src/DocFxToTemplate/Models/ItemViewModel.cs#L42"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public List<ReferenceViewModel> ImplementsRefs { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)&gt;   
   
### Href
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L44"
[YamlMember(Alias = "href")]
[JsonPropertyName("href")]
public string Href { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### InheritedMembersRefs
   
            
```csharp title="src/DocFxToTemplate/Models/ItemViewModel.cs#L47"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public List<ReferenceViewModel> InheritedMembersRefs { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)&gt;   
   
### SupportedLanguages
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L48"
[YamlMember(Alias = "langs")]
[JsonPropertyName("langs")]
public string[] SupportedLanguages { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)[]   
   
### ExtensionMethodsRefs
   
            
```csharp title="src/DocFxToTemplate/Models/ItemViewModel.cs#L52"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public List<ReferenceViewModel> ExtensionMethodsRefs { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)&gt;   
   
### Name
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L52"
[YamlMember(Alias = "name")]
[JsonPropertyName("name")]
public string Name { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Names
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L56"
[ExtensibleMember("name.")]
[JsonIgnore]
public SortedList<string, string> Names { get; set; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Link
   
            
```csharp title="src/DocFxToTemplate/Models/ItemViewModel.cs#L58"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public MarkdownLink? Link { get; set; }
```   

#### Property Value
[MarkdownLink](../DocFxToTemplate.Models.DocFx/MarkdownLink)   
   
### NameForCSharp
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L60"
[YamlIgnore]
[JsonIgnore]
public string NameForCSharp { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NameForVB
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L78"
[YamlIgnore]
[JsonIgnore]
public string NameForVB { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NameWithType
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L96"
[YamlMember(Alias = "nameWithType")]
[JsonPropertyName("nameWithType")]
public string NameWithType { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NamesWithType
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L100"
[ExtensibleMember("nameWithType.")]
[JsonIgnore]
public SortedList<string, string> NamesWithType { get; set; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### NameWithTypeForCSharp
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L104"
[YamlIgnore]
[JsonIgnore]
public string NameWithTypeForCSharp { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NameWithTypeForVB
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L122"
[YamlIgnore]
[JsonIgnore]
public string NameWithTypeForVB { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### FullName
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L140"
[YamlMember(Alias = "fullName")]
[JsonPropertyName("fullName")]
public string FullName { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### FullNames
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L144"
[ExtensibleMember("fullName.")]
[JsonIgnore]
public SortedList<string, string> FullNames { get; set; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### FullNameForCSharp
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L148"
[YamlIgnore]
[JsonIgnore]
public string FullNameForCSharp { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### FullNameForVB
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L166"
[YamlIgnore]
[JsonIgnore]
public string FullNameForVB { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Type
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L184"
[YamlMember(Alias = "type")]
[JsonPropertyName("type")]
public MemberType? Type { get; set; }
```   

#### Property Value
[MemberType](../DocFxToTemplate.Models.DocFx/MemberType)?   
   
### Source
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L188"
[YamlMember(Alias = "source")]
[JsonPropertyName("source")]
public SourceDetail? Source { get; set; }
```   

#### Property Value
[SourceDetail](../DocFxToTemplate.Models.DocFx/SourceDetail)   
   
### Documentation
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L192"
[YamlMember(Alias = "documentation")]
[JsonPropertyName("documentation")]
public SourceDetail Documentation { get; set; }
```   

#### Property Value
[SourceDetail](../DocFxToTemplate.Models.DocFx/SourceDetail)   
   
### AssemblyNameList
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L196"
[YamlMember(Alias = "assemblies")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("assemblies")]
public List<string>? AssemblyNameList { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### NamespaceName
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L201"
[YamlMember(Alias = "namespace")]
[JsonPropertyName("namespace")]
public string NamespaceName { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Summary
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L206"
[YamlMember(Alias = "summary")]
[JsonPropertyName("summary")]
public string Summary { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### AdditionalNotes
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L211"
[YamlMember(Alias = "additionalNotes")]
[JsonPropertyName("additionalNotes")]
public AdditionalNotes AdditionalNotes { get; set; }
```   

#### Property Value
[AdditionalNotes](../DocFxToTemplate.Models.DocFx/AdditionalNotes)   
   
### Remarks
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L215"
[YamlMember(Alias = "remarks")]
[JsonPropertyName("remarks")]
public string Remarks { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Examples
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L220"
[YamlMember(Alias = "example")]
[JsonPropertyName("example")]
[MergeOption(MergeOption.Replace)]
public List<string>? Examples { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Syntax
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L226"
[YamlMember(Alias = "syntax")]
[JsonPropertyName("syntax")]
public SyntaxDetailViewModel? Syntax { get; set; }
```   

#### Property Value
[SyntaxDetailViewModel](../DocFxToTemplate.Models.DocFx/SyntaxDetailViewModel)   
   
### Overridden
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L230"
[YamlMember(Alias = "overridden")]
[JsonPropertyName("overridden")]
public string Overridden { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Overload
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L235"
[YamlMember(Alias = "overload")]
[JsonPropertyName("overload")]
public string Overload { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Exceptions
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L240"
[YamlMember(Alias = "exceptions")]
[JsonPropertyName("exceptions")]
public List<ExceptionInfo>? Exceptions { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ExceptionInfo](../DocFxToTemplate.Models.DocFx/ExceptionInfo)&gt;   
   
### SeeAlsos
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L244"
[YamlMember(Alias = "seealso")]
[JsonPropertyName("seealso")]
public List<LinkInfo>? SeeAlsos { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[LinkInfo](../DocFxToTemplate.Models.DocFx/LinkInfo)&gt;   
   
### SeeAlsosUidReference
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L248"
[YamlIgnore]
[JsonIgnore]
public List<string> SeeAlsosUidReference { get; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Inheritance
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L254"
[YamlMember(Alias = "inheritance")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("inheritance")]
public List<string>? Inheritance { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### DerivedClasses
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L260"
[YamlMember(Alias = "derivedClasses")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("derivedClasses")]
public List<string>? DerivedClasses { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Implements
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L266"
[YamlMember(Alias = "implements")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("implements")]
public List<string>? Implements { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### InheritedMembers
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L272"
[YamlMember(Alias = "inheritedMembers")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("inheritedMembers")]
public List<string>? InheritedMembers { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### ExtensionMethods
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L278"
[YamlMember(Alias = "extensionMethods")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("extensionMethods")]
public List<string>? ExtensionMethods { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Conceptual
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L284"
[YamlMember(Alias = "conceptual")]
[JsonPropertyName("conceptual")]
public string Conceptual { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Platform
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L289"
[YamlMember(Alias = "platform")]
[JsonPropertyName("platform")]
[MergeOption(MergeOption.Replace)]
public List<string>? Platform { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Attributes
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L294"
[YamlMember(Alias = "attributes")]
[JsonPropertyName("attributes")]
[MergeOption(MergeOption.Ignore)]
public List<AttributeInfo>? Attributes { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[AttributeInfo](../DocFxToTemplate.Models.DocFx/AttributeInfo)&gt;   
   
### Metadata
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ItemViewModel.cs#L299"
[ExtensibleMember]
[JsonIgnore]
public Dictionary<string, object> Metadata { get; set; }
```   

#### Property Value
[Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [object](https://learn.microsoft.com/dotnet/api/system.object)&gt;   
   
   

   

   

   

   

   