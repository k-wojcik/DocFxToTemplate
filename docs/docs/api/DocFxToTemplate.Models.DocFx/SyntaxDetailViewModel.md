---
title: Class SyntaxDetailViewModel
sidebar_label: SyntaxDetailViewModel
description: TODO
---

# Class SyntaxDetailViewModel
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/SyntaxDetailViewModel.cs#L10](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/SyntaxDetailViewModel.cs#L10)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/SyntaxDetailViewModel.cs#L10" 
public class SyntaxDetailViewModel
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[SyntaxDetailViewModel](../DocFxToTemplate.Models.DocFx/SyntaxDetailViewModel)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Content
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SyntaxDetailViewModel.cs#L12"
[YamlMember(Alias = "content")]
[JsonPropertyName("content")]
public string Content { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### ContentForCSharp
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SyntaxDetailViewModel.cs#L20"
[YamlIgnore]
[JsonIgnore]
public string ContentForCSharp { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### ContentForVB
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SyntaxDetailViewModel.cs#L38"
[YamlIgnore]
[JsonIgnore]
public string ContentForVB { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Contents
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SyntaxDetailViewModel.cs#L16"
[ExtensibleMember("content.")]
[JsonIgnore]
public SortedList<string, string> Contents { get; set; }
```   

#### Property Value
[SortedList](https://learn.microsoft.com/dotnet/api/system.collections.generic.sortedlist-2)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
   
### Parameters
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SyntaxDetailViewModel.cs#L56"
[YamlMember(Alias = "parameters")]
[JsonPropertyName("parameters")]
public List<ApiParameter>? Parameters { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ApiParameter](../DocFxToTemplate.Models.DocFx/ApiParameter)&gt;   
   
### Return
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SyntaxDetailViewModel.cs#L64"
[YamlMember(Alias = "return")]
[JsonPropertyName("return")]
public ApiParameter? Return { get; set; }
```   

#### Property Value
[ApiParameter](../DocFxToTemplate.Models.DocFx/ApiParameter)   
   
### TypeParameters
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SyntaxDetailViewModel.cs#L60"
[YamlMember(Alias = "typeParameters")]
[JsonPropertyName("typeParameters")]
public List<ApiParameter>? TypeParameters { get; set; }
```   

#### Property Value
[List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1)&lt;[ApiParameter](../DocFxToTemplate.Models.DocFx/ApiParameter)&gt;   
   
   

   

   

   

   

   