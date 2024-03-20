---
title: Class GitDetail
sidebar_label: GitDetail
description: TODO
---

# Class GitDetail
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll
    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/GitDetail.cs#8" 
public record GitDetail : IEquatable<GitDetail>
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[GitDetail](../DocFxToTemplate.Models.DocFx/GitDetail)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

**Implements:**   
System.IEquatable\<DocFxToTemplate.Models.DocFx.GitDetail\>   

## Properties
### Branch
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/GitDetail.cs#17"
[YamlMember(Alias = "branch")]
[JsonPropertyName("branch")]
public string Branch { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Path
Relative path of current file to the Git Root Directory   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/GitDetail.cs#13"
[YamlMember(Alias = "path")]
[JsonPropertyName("path")]
public string Path { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Repo
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/GitDetail.cs#21"
[YamlMember(Alias = "repo")]
[JsonPropertyName("repo")]
public string Repo { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
   

   

   

   

## Implements
* System.IEquatable\<DocFxToTemplate.Models.DocFx.GitDetail\>
   

   