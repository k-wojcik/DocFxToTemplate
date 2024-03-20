---
title: Class AttributeInfo
sidebar_label: AttributeInfo
description: TODO
---

# Class AttributeInfo
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/AttributeInfo.cs#L10](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/AttributeInfo.cs#L10)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/AttributeInfo.cs#L10" 
public class AttributeInfo
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[AttributeInfo](../DocFxToTemplate.Models.DocFx/AttributeInfo)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Type
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/AttributeInfo.cs#L12"
[YamlMember(Alias = "type")]
[JsonPropertyName("type")]
public string Type { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Constructor
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/AttributeInfo.cs#L17"
[YamlMember(Alias = "ctor")]
[JsonPropertyName("ctor")]
public string Constructor { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Arguments
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/AttributeInfo.cs#L21"
[YamlMember(Alias = "arguments")]
[JsonPropertyName("arguments")]
public List<ArgumentInfo> Arguments { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ArgumentInfo](../DocFxToTemplate.Models.DocFx/ArgumentInfo)&gt;   
   
### NamedArguments
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/AttributeInfo.cs#L25"
[YamlMember(Alias = "namedArguments")]
[JsonPropertyName("namedArguments")]
public List<NamedArgumentInfo> NamedArguments { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[NamedArgumentInfo](../DocFxToTemplate.Models.DocFx/NamedArgumentInfo)&gt;   
   
   

   

   

   

   

   