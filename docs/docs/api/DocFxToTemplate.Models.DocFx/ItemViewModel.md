---
title: Class ItemViewModel
sidebar_label: ItemViewModel
description: TODO
---

# Class ItemViewModel
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll
    
   

```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\ItemViewModel.cs#8" 
public class ItemViewModel
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### AdditionalNotes
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#210"
[YamlMember(Alias = "additionalNotes")]
[JsonPropertyName("additionalNotes")]
public AdditionalNotes AdditionalNotes { get; set; }
```   

#### Property Value
[AdditionalNotes](../DocFxToTemplate.Models.DocFx/AdditionalNotes)   
   
### AssemblyNameList
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#195"
[YamlMember(Alias = "assemblies")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("assemblies")]
public List<string>? AssemblyNameList { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Attributes
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#293"
[YamlMember(Alias = "attributes")]
[JsonPropertyName("attributes")]
[MergeOption(MergeOption.Ignore)]
public List<AttributeInfo>? Attributes { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[AttributeInfo](../DocFxToTemplate.Models.DocFx/AttributeInfo)&gt;   
   
### Children
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#37"
[YamlMember(Alias = "children")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("children")]
public List<string>? Children { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### CommentId
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#16"
[YamlMember(Alias = "commentId")]
[JsonPropertyName("commentId")]
public string? CommentId { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Conceptual
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#283"
[YamlMember(Alias = "conceptual")]
[JsonPropertyName("conceptual")]
public string Conceptual { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### DerivedClasses
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#259"
[YamlMember(Alias = "derivedClasses")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("derivedClasses")]
public List<string>? DerivedClasses { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### DerivedClassesRefs
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\ItemViewModel.cs#36"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public List<ReferenceViewModel> DerivedClassesRefs { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)&gt;   
   
### Documentation
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#191"
[YamlMember(Alias = "documentation")]
[JsonPropertyName("documentation")]
public SourceDetail Documentation { get; set; }
```   

#### Property Value
[SourceDetail](../DocFxToTemplate.Models.DocFx/SourceDetail)   
   
### Events
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\ItemViewModel.cs#26"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public ItemViewModel[] Events { get; set; }
```   

#### Property Value
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)[]   
   
### Examples
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#219"
[YamlMember(Alias = "example")]
[JsonPropertyName("example")]
[MergeOption(MergeOption.Replace)]
public List<string>? Examples { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Exceptions
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#239"
[YamlMember(Alias = "exceptions")]
[JsonPropertyName("exceptions")]
public List<ExceptionInfo>? Exceptions { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ExceptionInfo](../DocFxToTemplate.Models.DocFx/ExceptionInfo)&gt;   
   
### ExtensionMethods
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#277"
[YamlMember(Alias = "extensionMethods")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("extensionMethods")]
public List<string>? ExtensionMethods { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### ExtensionMethodsRefs
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\ItemViewModel.cs#51"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public List<ReferenceViewModel> ExtensionMethodsRefs { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)&gt;   
   
### Fields
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\ItemViewModel.cs#16"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public ItemViewModel[] Fields { get; set; }
```   

#### Property Value
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)[]   
   
### FullName
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#139"
[YamlMember(Alias = "fullName")]
[JsonPropertyName("fullName")]
public string FullName { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### FullNameForCSharp
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#147"
[YamlIgnore]
[JsonIgnore]
public string FullNameForCSharp { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### FullNameForVB
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#165"
[YamlIgnore]
[JsonIgnore]
public string FullNameForVB { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### FullNames
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#143"
[ExtensibleMember("fullName.")]
[JsonIgnore]
public SortedList<string, string> FullNames { get; set; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Href
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#43"
[YamlMember(Alias = "href")]
[JsonPropertyName("href")]
public string Href { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Id
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#20"
[YamlMember(Alias = "id")]
[JsonPropertyName("id")]
public string? Id { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Implements
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#265"
[YamlMember(Alias = "implements")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("implements")]
public List<string>? Implements { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### ImplementsRefs
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\ItemViewModel.cs#41"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public List<ReferenceViewModel> ImplementsRefs { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)&gt;   
   
### Inheritance
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#253"
[YamlMember(Alias = "inheritance")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("inheritance")]
public List<string>? Inheritance { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### InheritanceRefs
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\ItemViewModel.cs#31"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public List<ReferenceViewModel> InheritanceRefs { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)&gt;   
   
### InheritedMembers
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#271"
[YamlMember(Alias = "inheritedMembers")]
[MergeOption(MergeOption.Ignore)]
[JsonPropertyName("inheritedMembers")]
public List<string>? InheritedMembers { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### InheritedMembersRefs
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\ItemViewModel.cs#46"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public List<ReferenceViewModel> InheritedMembersRefs { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)&gt;   
   
### IsExplicitInterfaceImplementation
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#24"
[YamlMember(Alias = "isEii")]
[JsonPropertyName("isEii")]
public bool IsExplicitInterfaceImplementation { get; set; }
```   

#### Property Value
[bool](https://learn.microsoft.com/dotnet/api/system.boolean)   
   
### IsExtensionMethod
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#28"
[YamlMember(Alias = "isExtensionMethod")]
[JsonPropertyName("isExtensionMethod")]
public bool IsExtensionMethod { get; set; }
```   

#### Property Value
[bool](https://learn.microsoft.com/dotnet/api/system.boolean)   
   
### Link
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\ItemViewModel.cs#57"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public MarkdownLink? Link { get; set; }
```   

#### Property Value
[MarkdownLink](../DocFxToTemplate.Models.DocFx/MarkdownLink)   
   
### Metadata
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#298"
[ExtensibleMember]
[JsonIgnore]
public Dictionary<string, object> Metadata { get; set; }
```   

#### Property Value
[Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [object](https://learn.microsoft.com/dotnet/api/system.object)&gt;   
   
### Methods
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\ItemViewModel.cs#21"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public ItemViewModel[] Methods { get; set; }
```   

#### Property Value
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)[]   
   
### Name
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#51"
[YamlMember(Alias = "name")]
[JsonPropertyName("name")]
public string Name { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NameForCSharp
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#59"
[YamlIgnore]
[JsonIgnore]
public string NameForCSharp { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NameForVB
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#77"
[YamlIgnore]
[JsonIgnore]
public string NameForVB { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Names
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#55"
[ExtensibleMember("name.")]
[JsonIgnore]
public SortedList<string, string> Names { get; set; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### NamespaceName
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#200"
[YamlMember(Alias = "namespace")]
[JsonPropertyName("namespace")]
public string NamespaceName { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NamesWithType
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#99"
[ExtensibleMember("nameWithType.")]
[JsonIgnore]
public SortedList<string, string> NamesWithType { get; set; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### NameWithType
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#95"
[YamlMember(Alias = "nameWithType")]
[JsonPropertyName("nameWithType")]
public string NameWithType { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NameWithTypeForCSharp
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#103"
[YamlIgnore]
[JsonIgnore]
public string NameWithTypeForCSharp { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NameWithTypeForVB
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#121"
[YamlIgnore]
[JsonIgnore]
public string NameWithTypeForVB { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Overload
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#234"
[YamlMember(Alias = "overload")]
[JsonPropertyName("overload")]
public string Overload { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Overridden
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#229"
[YamlMember(Alias = "overridden")]
[JsonPropertyName("overridden")]
public string Overridden { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Parent
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#32"
[YamlMember(Alias = "parent")]
[JsonPropertyName("parent")]
public string Parent { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Platform
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#288"
[YamlMember(Alias = "platform")]
[JsonPropertyName("platform")]
[MergeOption(MergeOption.Replace)]
public List<string>? Platform { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Properties
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\ItemViewModel.cs#11"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public ItemViewModel[] Properties { get; set; }
```   

#### Property Value
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)[]   
   
### Remarks
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#214"
[YamlMember(Alias = "remarks")]
[JsonPropertyName("remarks")]
public string Remarks { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### SeeAlsos
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#243"
[YamlMember(Alias = "seealso")]
[JsonPropertyName("seealso")]
public List<LinkInfo>? SeeAlsos { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[LinkInfo](../DocFxToTemplate.Models.DocFx/LinkInfo)&gt;   
   
### SeeAlsosUidReference
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#247"
[YamlIgnore]
[JsonIgnore]
public List<string> SeeAlsosUidReference { get; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Source
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#187"
[YamlMember(Alias = "source")]
[JsonPropertyName("source")]
public SourceDetail? Source { get; set; }
```   

#### Property Value
[SourceDetail](../DocFxToTemplate.Models.DocFx/SourceDetail)   
   
### Summary
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#205"
[YamlMember(Alias = "summary")]
[JsonPropertyName("summary")]
public string Summary { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### SupportedLanguages
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#47"
[YamlMember(Alias = "langs")]
[JsonPropertyName("langs")]
public string[] SupportedLanguages { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)[]   
   
### Syntax
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#225"
[YamlMember(Alias = "syntax")]
[JsonPropertyName("syntax")]
public SyntaxDetailViewModel? Syntax { get; set; }
```   

#### Property Value
[SyntaxDetailViewModel](../DocFxToTemplate.Models.DocFx/SyntaxDetailViewModel)   
   
### Type
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#183"
[YamlMember(Alias = "type")]
[JsonPropertyName("type")]
public MemberType? Type { get; set; }
```   

#### Property Value
[MemberType](../DocFxToTemplate.Models.DocFx/MemberType)?   
   
### Uid
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ItemViewModel.cs#11"
[YamlMember(Alias = "uid")]
[JsonPropertyName("uid")]
[MergeOption(MergeOption.MergeKey)]
public string? Uid { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
   

   

   

   

   

   