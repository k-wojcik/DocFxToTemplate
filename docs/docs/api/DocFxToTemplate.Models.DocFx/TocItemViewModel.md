---
title: Class TocItemViewModel
sidebar_label: TocItemViewModel
description: TODO
---

# Class TocItemViewModel
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L11](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L11)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L11" 
public class TocItemViewModel
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[TocItemViewModel](../DocFxToTemplate.Models.DocFx/TocItemViewModel)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals)   

   

## Properties
### AggregatedHref
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L49"
[YamlIgnore]
[JsonIgnore]
public string AggregatedHref { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### AggregatedUid
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L75"
[YamlIgnore]
[JsonIgnore]
public string AggregatedUid { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### DisplayName
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L21"
[YamlMember(Alias = "displayName")]
[JsonPropertyName("displayName")]
public string DisplayName { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Homepage
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L55"
[YamlMember(Alias = "homepage")]
[JsonPropertyName("homepage")]
public string Homepage { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### HomepageUid
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L63"
[YamlMember(Alias = "homepageUid")]
[JsonPropertyName("homepageUid")]
public string HomepageUid { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Href
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L25"
[YamlMember(Alias = "href")]
[JsonPropertyName("href")]
public string Href { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### IncludedFrom
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L51"
[YamlMember(Alias = "includedFrom")]
[JsonPropertyName("includedFrom")]
public string IncludedFrom { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### IsHrefUpdated
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L81"
[YamlIgnore]
[JsonIgnore]
public bool IsHrefUpdated { get; set; }
```   

#### Property Value
[bool](https://learn.microsoft.com/dotnet/api/system.boolean)   
   
### Items
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L77"
[YamlMember(Alias = "items")]
[JsonPropertyName("items")]
public List<TocItemViewModel> Items { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[TocItemViewModel](../DocFxToTemplate.Models.DocFx/TocItemViewModel)&gt;   
   
### Metadata
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L83"
[ExtensibleMember]
[JsonIgnore]
public Dictionary<string, object> Metadata { get; set; }
```   

#### Property Value
[Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [object](https://learn.microsoft.com/dotnet/api/system.object)&gt;   
   
### Name
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L17"
[YamlMember(Alias = "name")]
[JsonPropertyName("name")]
public string Name { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Order
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L71"
[YamlMember(Alias = "order")]
[JsonPropertyName("order")]
public int? Order { get; set; }
```   

#### Property Value
[int](https://learn.microsoft.com/dotnet/api/system.int32)?   
   
### OriginalHomepage
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L59"
[YamlMember(Alias = "originalHomepage")]
[JsonPropertyName("originalHomepage")]
public string OriginalHomepage { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### OriginalHref
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L29"
[YamlMember(Alias = "originalHref")]
[JsonPropertyName("originalHref")]
public string OriginalHref { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### OriginalTocHref
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L37"
[YamlMember(Alias = "originalTocHref")]
[JsonPropertyName("originalTocHref")]
public string OriginalTocHref { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### OriginalTopicHref
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L45"
[YamlMember(Alias = "originalTopicHref")]
[JsonPropertyName("originalTopicHref")]
public string OriginalTopicHref { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### TocHref
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L33"
[YamlMember(Alias = "tocHref")]
[JsonPropertyName("tocHref")]
public string TocHref { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### TopicHref
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L41"
[YamlMember(Alias = "topicHref")]
[JsonPropertyName("topicHref")]
public string TopicHref { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### TopicUid
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L67"
[YamlMember(Alias = "topicUid")]
[JsonPropertyName("topicUid")]
public string TopicUid { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Uid
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/TocItemViewModel.cs#L13"
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

   

   

   

   