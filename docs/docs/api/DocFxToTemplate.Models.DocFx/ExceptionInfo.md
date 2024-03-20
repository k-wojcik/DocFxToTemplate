---
title: Class ExceptionInfo
sidebar_label: ExceptionInfo
description: TODO
---

# Class ExceptionInfo
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll
    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/ExceptionInfo.cs#9" 
public class ExceptionInfo
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[ExceptionInfo](../DocFxToTemplate.Models.DocFx/ExceptionInfo)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### CommentId
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ExceptionInfo.cs#17"
[YamlMember(Alias = "commentId")]
[JsonPropertyName("commentId")]
public string CommentId { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Description
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ExceptionInfo.cs#21"
[YamlMember(Alias = "description")]
[JsonPropertyName("description")]
public string Description { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Type
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ExceptionInfo.cs#11"
[YamlMember(Alias = "type")]
[MergeOption(MergeOption.MergeKey)]
[JsonPropertyName("type")]
public string Type { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
   

   

   

   

   

   