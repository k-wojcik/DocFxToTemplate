---
title: Class ReferenceViewModel
sidebar_label: ReferenceViewModel
description: TODO
---

# Class ReferenceViewModel
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll
    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#9" 
public class ReferenceViewModel
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Additional
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#71"
[ExtensibleMember]
[JsonIgnore]
public Dictionary<string, object> Additional { get; }
```   

#### Property Value
[Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [object](https://learn.microsoft.com/dotnet/api/system.object)&gt;   
   
### CommentId
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#15"
[YamlMember(Alias = "commentId")]
[JsonPropertyName("commentId")]
public string CommentId { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Definition
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#23"
[YamlMember(Alias = "definition")]
[JsonPropertyName("definition")]
public string Definition { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### FullName
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#52"
[YamlMember(Alias = "fullName")]
[JsonPropertyName("fullName")]
public string FullName { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### FullNameInDevLangs
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#56"
[ExtensibleMember("fullName.")]
[JsonIgnore]
public SortedList<string, string> FullNameInDevLangs { get; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Href
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#32"
[YamlMember(Alias = "href")]
[JsonPropertyName("href")]
public string Href { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### IsExternal
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#28"
[YamlMember(Alias = "isExternal")]
[JsonPropertyName("isExternal")]
public bool? IsExternal { get; set; }
```   

#### Property Value
[bool](https://learn.microsoft.com/dotnet/api/system.boolean)?   
   
### Item
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#67"
[YamlIgnore]
[JsonIgnore]
public ItemViewModel? Item { get; set; }
```   

#### Property Value
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)   
   
### Name
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#36"
[YamlMember(Alias = "name")]
[JsonPropertyName("name")]
public string Name { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NameInDevLangs
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#40"
[ExtensibleMember("name.")]
[JsonIgnore]
public SortedList<string, string> NameInDevLangs { get; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### NameWithType
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#44"
[YamlMember(Alias = "nameWithType")]
[JsonPropertyName("nameWithType")]
public string NameWithType { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NameWithTypeInDevLangs
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#48"
[ExtensibleMember("nameWithType.")]
[JsonIgnore]
public SortedList<string, string> NameWithTypeInDevLangs { get; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Parent
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#19"
[YamlMember(Alias = "parent")]
[JsonPropertyName("parent")]
public string Parent { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### SpecCsharp
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#64"
[YamlMember(Alias = "spec.csharp")]
public List<SpecViewModel> SpecCsharp { get; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[SpecViewModel](../DocFxToTemplate.Models.DocFx/SpecViewModel)&gt;   
   
### Uid
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ReferenceViewModel.cs#11"
[YamlMember(Alias = "uid")]
[JsonPropertyName("uid")]
public string Uid { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
   

   

   

   

   

   