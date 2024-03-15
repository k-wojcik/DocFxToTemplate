---
title: Class AttributeInfo
sidebar_label: AttributeInfo
description: TODO
---

# Class AttributeInfo
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll
    
   

```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\AttributeInfo.cs#9" 
public class AttributeInfo
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[AttributeInfo](../DocFxToTemplate.Models.DocFx/AttributeInfo)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Arguments
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\AttributeInfo.cs#20"
[YamlMember(Alias = "arguments")]
[JsonPropertyName("arguments")]
public List<ArgumentInfo> Arguments { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ArgumentInfo](../DocFxToTemplate.Models.DocFx/ArgumentInfo)&gt;   
   
### Constructor
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\AttributeInfo.cs#16"
[YamlMember(Alias = "ctor")]
[JsonPropertyName("ctor")]
public string Constructor { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### NamedArguments
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\AttributeInfo.cs#24"
[YamlMember(Alias = "namedArguments")]
[JsonPropertyName("namedArguments")]
public List<NamedArgumentInfo> NamedArguments { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[NamedArgumentInfo](../DocFxToTemplate.Models.DocFx/NamedArgumentInfo)&gt;   
   
### Type
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\AttributeInfo.cs#11"
[YamlMember(Alias = "type")]
[JsonPropertyName("type")]
public string Type { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
   

   

   

   

   

   