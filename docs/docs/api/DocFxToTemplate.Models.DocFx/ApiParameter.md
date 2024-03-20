---
title: Class ApiParameter
sidebar_label: ApiParameter
description: TODO
---

# Class ApiParameter
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/ApiParameter.cs#L11](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/ApiParameter.cs#L11)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/ApiParameter.cs#L11" 
public class ApiParameter
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[ApiParameter](../DocFxToTemplate.Models.DocFx/ApiParameter)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Name
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ApiParameter.cs#L13"
[YamlMember(Alias = "id")]
[JsonPropertyName("id")]
[MergeOption(MergeOption.MergeKey)]
public string Name { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Type
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ApiParameter.cs#L18"
[YamlMember(Alias = "type")]
[JsonPropertyName("type")]
public string Type { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Description
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ApiParameter.cs#L23"
[YamlMember(Alias = "description")]
[JsonPropertyName("description")]
public string Description { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Attributes
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ApiParameter.cs#L28"
[YamlMember(Alias = "attributes")]
[JsonPropertyName("attributes")]
[MergeOption(MergeOption.Ignore)]
public List<AttributeInfo> Attributes { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[AttributeInfo](../DocFxToTemplate.Models.DocFx/AttributeInfo)&gt;   
   
### Reference
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ApiParameter.cs#L33"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public ReferenceViewModel? Reference { get; set; }
```   

#### Property Value
[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)   
   
   

   

   

   

   

   