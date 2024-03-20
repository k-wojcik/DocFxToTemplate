---
title: Class ArgumentInfo
sidebar_label: ArgumentInfo
description: TODO
---

# Class ArgumentInfo
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/ArgumentInfo.cs#L10](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/ArgumentInfo.cs#L10)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/ArgumentInfo.cs#L10" 
public class ArgumentInfo
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[ArgumentInfo](../DocFxToTemplate.Models.DocFx/ArgumentInfo)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Type
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ArgumentInfo.cs#L12"
[YamlMember(Alias = "type")]
[JsonPropertyName("type")]
public string Type { get; set; }
```   

#### Property value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Value
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ArgumentInfo.cs#L17"
[YamlMember(Alias = "value")]
[JsonPropertyName("value")]
public object Value { get; set; }
```   

#### Property value
[object](https://learn.microsoft.com/dotnet/api/system.object)   
   
   

   

   

   

   

   