---
title: Class ApiParameter
sidebar_label: ApiParameter
description: TODO
---

# Class ApiParameter
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll
    
   

```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ApiParameter.cs#10" 
public class ApiParameter
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[ApiParameter](../DocFxToTemplate.Models.DocFx/ApiParameter)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Attributes
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ApiParameter.cs#27"
[YamlMember(Alias = "attributes")]
[JsonPropertyName("attributes")]
[MergeOption(MergeOption.Ignore)]
public List<AttributeInfo> Attributes { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[AttributeInfo](../DocFxToTemplate.Models.DocFx/AttributeInfo)&gt;   
   
### Description
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ApiParameter.cs#22"
[YamlMember(Alias = "description")]
[JsonPropertyName("description")]
public string Description { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Name
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ApiParameter.cs#12"
[YamlMember(Alias = "id")]
[JsonPropertyName("id")]
[MergeOption(MergeOption.MergeKey)]
public string Name { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Reference
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ApiParameter.cs#32"
[JsonIgnore]
[YamlIgnore]
[IgnoreDataMember]
public ReferenceViewModel? Reference { get; set; }
```   

#### Property Value
[ReferenceViewModel](../DocFxToTemplate.Models.DocFx/ReferenceViewModel)   
   
### Type
   
            
```csharp title="T:\Projekty\DocFxToTemplate\src\DocFxToTemplate\Models\DocFx\ApiParameter.cs#17"
[YamlMember(Alias = "type")]
[JsonPropertyName("type")]
public string Type { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
   

   

   

   

   

   