---
title: Class PageViewModel
sidebar_label: PageViewModel
description: TODO
---

# Class PageViewModel
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/PageViewModel.cs#L9](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/PageViewModel.cs#L9)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/PageViewModel.cs#L9" 
public class PageViewModel
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[PageViewModel](../DocFxToTemplate.Models.DocFx/PageViewModel)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Items
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/PageViewModel.cs#L11"
[YamlMember(Alias = "items")]
[JsonPropertyName("items")]
public List<ItemViewModel> Items { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)&gt;   
   
### References
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/PageViewModel.cs#L15"
[YamlMember(Alias = "references")]
[JsonPropertyName("references")]
public List<ReferenceViewModel> References { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)&gt;   
   
### ShouldSkipMarkup
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/PageViewModel.cs#L19"
[YamlMember(Alias = "shouldSkipMarkup")]
[JsonPropertyName("shouldSkipMarkup")]
public bool ShouldSkipMarkup { get; set; }
```   

#### Property Value
[bool](https://learn.microsoft.com/dotnet/api/system.boolean)   
   
### Metadata
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/PageViewModel.cs#L24"
[JsonExtensionData]
public Dictionary<string, object> Metadata { get; set; }
```   

#### Property Value
[Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [object](https://learn.microsoft.com/dotnet/api/system.object)&gt;   
   
   

   

   

   

   

   