---
title: Class SpecViewModel
sidebar_label: SpecViewModel
description: TODO
---

# Class SpecViewModel
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#L9](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#L9)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#L9" 
public class SpecViewModel
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[SpecViewModel](../DocFxToTemplate.Models.DocFx/SpecViewModel)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Uid
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#L11"
[YamlMember(Alias = "uid")]
[JsonPropertyName("uid")]
public string Uid { get; set; }
```   

#### Property value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Name
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#L15"
[YamlMember(Alias = "name")]
[JsonPropertyName("name")]
public string Name { get; set; }
```   

#### Property value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### IsExternal
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#L19"
[YamlMember(Alias = "isExternal")]
[JsonPropertyName("isExternal")]
public bool IsExternal { get; set; }
```   

#### Property value
[bool](https://learn.microsoft.com/dotnet/api/system.boolean)   
   
### Href
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#L23"
[YamlMember(Alias = "href")]
[JsonPropertyName("href")]
public string Href { get; set; }
```   

#### Property value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Item
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SpecViewModel.cs#L27"
[JsonIgnore]
[YamlIgnore]
public ItemViewModel? Item { get; set; }
```   

#### Property value
[ItemViewModel](../DocFxToTemplate.Models.DocFx/ItemViewModel)   
   
   

   

   

   

   

   