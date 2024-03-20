---
title: Class ReferenceViewModel
sidebar_label: ReferenceViewModel
description: TODO
---

# Class ReferenceViewModel
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L10](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L10)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L10" 
public class ReferenceViewModel
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Uid
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L12"
[YamlMember(Alias = "uid")]
[JsonPropertyName("uid")]
public string Uid { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### CommentId
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L16"
[YamlMember(Alias = "commentId")]
[JsonPropertyName("commentId")]
public string CommentId { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Parent
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L20"
[YamlMember(Alias = "parent")]
[JsonPropertyName("parent")]
public string Parent { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Definition
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L24"
[YamlMember(Alias = "definition")]
[JsonPropertyName("definition")]
public string Definition { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### IsExternal
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L29"
[YamlMember(Alias = "isExternal")]
[JsonPropertyName("isExternal")]
public bool? IsExternal { get; set; }
```   

#### Property Value
[bool](https://learn.microsoft.com/dotnet/api/system.boolean)?   
   
### Href
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L33"
[YamlMember(Alias = "href")]
[JsonPropertyName("href")]
public string Href { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Name
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L37"
[YamlMember(Alias = "name")]
[JsonPropertyName("name")]
public string Name { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NameInDevLangs
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L41"
[ExtensibleMember("name.")]
[JsonIgnore]
public SortedList<string, string> NameInDevLangs { get; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### NameWithType
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L45"
[YamlMember(Alias = "nameWithType")]
[JsonPropertyName("nameWithType")]
public string NameWithType { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NameWithTypeInDevLangs
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L49"
[ExtensibleMember("nameWithType.")]
[JsonIgnore]
public SortedList<string, string> NameWithTypeInDevLangs { get; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### FullName
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L53"
[YamlMember(Alias = "fullName")]
[JsonPropertyName("fullName")]
public string FullName { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### FullNameInDevLangs
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L57"
[ExtensibleMember("fullName.")]
[JsonIgnore]
public SortedList<string, string> FullNameInDevLangs { get; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### SpecCsharp
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L65"
[YamlMember(Alias = "spec.csharp")]
public List<SpecViewModel> SpecCsharp { get; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[SpecViewModel](../DocFxToTemplate.Models.DocFx/SpecViewModel)&gt;   
   
### Item
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L68"
[YamlIgnore]
[JsonIgnore]
public ItemViewModel? Item { get; set; }
```   

#### Property Value
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)   
   
### Additional
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#L72"
[ExtensibleMember]
[JsonIgnore]
public Dictionary<string, object> Additional { get; }
```   

#### Property Value
[Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [object](https://learn.microsoft.com/dotnet/api/system.object)&gt;   
   
   

   

   

   

   

   