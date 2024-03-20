---
title: Class SourceDetail
sidebar_label: SourceDetail
description: TODO
---

# Class SourceDetail
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll
    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/SourceDetail.cs#8" 
public class SourceDetail
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[SourceDetail](../DocFxToTemplate.Models.DocFx/SourceDetail)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### EndLine
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SourceDetail.cs#36"
[YamlMember(Alias = "endLine")]
[JsonPropertyName("endLine")]
public int EndLine { get; set; }
```   

#### Property Value
[int](https://learn.microsoft.com/dotnet/api/system.int32)   
   
### Href
The url path for current source, should be resolved at some late stage   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SourceDetail.cs#21"
[YamlMember(Alias = "href")]
[JsonPropertyName("href")]
public string Href { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Name
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SourceDetail.cs#14"
[YamlMember(Alias = "id")]
[JsonPropertyName("id")]
public string Name { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Path
The local path for current source, should be resolved to be relative path at some late stage   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SourceDetail.cs#28"
[YamlMember(Alias = "path")]
[JsonPropertyName("path")]
public string Path { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Remote
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SourceDetail.cs#10"
[YamlMember(Alias = "remote")]
[JsonPropertyName("remote")]
public GitDetail Remote { get; set; }
```   

#### Property Value
[GitDetail](../DocFxToTemplate.Models.DocFx/GitDetail)   
   
### StartLine
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/SourceDetail.cs#32"
[YamlMember(Alias = "startLine")]
[JsonPropertyName("startLine")]
public int StartLine { get; set; }
```   

#### Property Value
[int](https://learn.microsoft.com/dotnet/api/system.int32)   
   
   

   

   

   

   

   