---
title: Class ExceptionInfo
sidebar_label: ExceptionInfo
description: TODO
---

# Class ExceptionInfo
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/ExceptionInfo.cs#L10](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/ExceptionInfo.cs#L10)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/ExceptionInfo.cs#L10" 
public class ExceptionInfo
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[ExceptionInfo](../DocFxToTemplate.Models.DocFx/ExceptionInfo)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### Type
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ExceptionInfo.cs#L12"
[YamlMember(Alias = "type")]
[MergeOption(MergeOption.MergeKey)]
[JsonPropertyName("type")]
public string Type { get; set; }
```   

#### Property value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### CommentId
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ExceptionInfo.cs#L18"
[YamlMember(Alias = "commentId")]
[JsonPropertyName("commentId")]
public string CommentId { get; set; }
```   

#### Property value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### Description
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/ExceptionInfo.cs#L22"
[YamlMember(Alias = "description")]
[JsonPropertyName("description")]
public string Description { get; set; }
```   

#### Property value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
   

   

   

   

   

   