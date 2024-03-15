---
title: Class TocItemViewModel
sidebar_label: TocItemViewModel
description: TODO
---

# Class TocItemViewModel
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll
    
   

```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#10" 
public class TocItemViewModel
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[TocItemViewModel](../DocFxToTemplate.Models.DocFx/TocItemViewModel)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals)   

   

## Properties
### AggregatedHref
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#48"
[YamlIgnore]
[JsonIgnore]
public string AggregatedHref { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### AggregatedUid
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#74"
[YamlIgnore]
[JsonIgnore]
public string AggregatedUid { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### DisplayName
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#20"
[YamlMember(Alias = "displayName")]
[JsonPropertyName("displayName")]
public string DisplayName { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Homepage
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#54"
[YamlMember(Alias = "homepage")]
[JsonPropertyName("homepage")]
public string Homepage { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### HomepageUid
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#62"
[YamlMember(Alias = "homepageUid")]
[JsonPropertyName("homepageUid")]
public string HomepageUid { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Href
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#24"
[YamlMember(Alias = "href")]
[JsonPropertyName("href")]
public string Href { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### IncludedFrom
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#50"
[YamlMember(Alias = "includedFrom")]
[JsonPropertyName("includedFrom")]
public string IncludedFrom { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### IsHrefUpdated
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#80"
[YamlIgnore]
[JsonIgnore]
public bool IsHrefUpdated { get; set; }
```   

#### Property Value
[bool](https://learn.microsoft.com/dotnet/api/system.boolean)   
   
### Items
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#76"
[YamlMember(Alias = "items")]
[JsonPropertyName("items")]
public List<TocItemViewModel> Items { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[TocItemViewModel](../DocFxToTemplate.Models.DocFx/TocItemViewModel)&gt;   
   
### Metadata
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#82"
[ExtensibleMember]
[JsonIgnore]
public Dictionary<string, object> Metadata { get; set; }
```   

#### Property Value
[Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [object](https://learn.microsoft.com/dotnet/api/system.object)&gt;   
   
### Name
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#16"
[YamlMember(Alias = "name")]
[JsonPropertyName("name")]
public string Name { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Order
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#70"
[YamlMember(Alias = "order")]
[JsonPropertyName("order")]
public int? Order { get; set; }
```   

#### Property Value
[int](https://learn.microsoft.com/dotnet/api/system.int32)?   
   
### OriginalHomepage
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#58"
[YamlMember(Alias = "originalHomepage")]
[JsonPropertyName("originalHomepage")]
public string OriginalHomepage { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### OriginalHref
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#28"
[YamlMember(Alias = "originalHref")]
[JsonPropertyName("originalHref")]
public string OriginalHref { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### OriginalTocHref
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#36"
[YamlMember(Alias = "originalTocHref")]
[JsonPropertyName("originalTocHref")]
public string OriginalTocHref { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### OriginalTopicHref
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#44"
[YamlMember(Alias = "originalTopicHref")]
[JsonPropertyName("originalTopicHref")]
public string OriginalTopicHref { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### TocHref
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#32"
[YamlMember(Alias = "tocHref")]
[JsonPropertyName("tocHref")]
public string TocHref { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### TopicHref
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#40"
[YamlMember(Alias = "topicHref")]
[JsonPropertyName("topicHref")]
public string TopicHref { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### TopicUid
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#66"
[YamlMember(Alias = "topicUid")]
[JsonPropertyName("topicUid")]
public string TopicUid { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Uid
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\TocItemViewModel.cs#12"
[YamlMember(Alias = "uid")]
[JsonPropertyName("uid")]
public string Uid { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
   

   

## Methods
### Clone()
   

#### Returns
 [TocItemViewModel](../DocFxToTemplate.Models.DocFx/TocItemViewModel)    
   

### ToString()
Returns a string that represents the current object.   

#### Returns
 [string](https://learn.microsoft.com/dotnet/api/system.string)    
A string that represents the current object.   

   

   

   

   