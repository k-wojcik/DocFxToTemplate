---
title: Class NamedArgumentInfo
sidebar_label: NamedArgumentInfo
description: TODO
---

# Class NamedArgumentInfo
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/NamedArgumentInfo.cs#L10](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/NamedArgumentInfo.cs#L10)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/NamedArgumentInfo.cs#L10" 
public class NamedArgumentInfo
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[NamedArgumentInfo](../DocFxToTemplate.Models.DocFx/NamedArgumentInfo)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Name
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/NamedArgumentInfo.cs#L12"
[YamlMember(Alias = "name")]
[JsonPropertyName("name")]
public string Name { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Type
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/NamedArgumentInfo.cs#L16"
[YamlMember(Alias = "type")]
[JsonPropertyName("type")]
public string Type { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Value
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/NamedArgumentInfo.cs#L21"
[YamlMember(Alias = "value")]
[JsonPropertyName("value")]
public object Value { get; set; }
```   

#### Property Value
[object](https://learn.microsoft.com/dotnet/api/system.object)   
   
   

   

   

   

   

   