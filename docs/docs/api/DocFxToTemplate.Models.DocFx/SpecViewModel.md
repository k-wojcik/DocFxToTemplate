---
title: Class SpecViewModel
sidebar_label: SpecViewModel
description: TODO
---

# Class SpecViewModel
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll
    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#8" 
public class SpecViewModel
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[SpecViewModel](../DocFxToTemplate.Models.DocFx/SpecViewModel)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Href
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#22"
[YamlMember(Alias = "href")]
[JsonPropertyName("href")]
public string Href { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### IsExternal
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#18"
[YamlMember(Alias = "isExternal")]
[JsonPropertyName("isExternal")]
public bool IsExternal { get; set; }
```   

#### Property Value
[bool](https://learn.microsoft.com/dotnet/api/system.boolean)   
   
### Item
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#26"
[JsonIgnore]
[YamlIgnore]
public ItemViewModel? Item { get; set; }
```   

#### Property Value
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)   
   
### Name
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#14"
[YamlMember(Alias = "name")]
[JsonPropertyName("name")]
public string Name { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Uid
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#10"
[YamlMember(Alias = "uid")]
[JsonPropertyName("uid")]
public string Uid { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
   

   

   

   

   

   