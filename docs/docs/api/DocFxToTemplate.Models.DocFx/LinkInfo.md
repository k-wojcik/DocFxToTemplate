---
title: Class LinkInfo
sidebar_label: LinkInfo
description: TODO
---

# Class LinkInfo
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/LinkInfo.cs#L10](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/LinkInfo.cs#L10)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/LinkInfo.cs#L10" 
public class LinkInfo
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[LinkInfo](../DocFxToTemplate.Models.DocFx/LinkInfo)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

## Properties
### AltText
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/LinkInfo.cs#L27"
[YamlMember(Alias = "altText")]
[JsonPropertyName("altText")]
public string AltText { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### CommentId
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/LinkInfo.cs#L22"
[YamlMember(Alias = "commentId")]
[JsonPropertyName("commentId")]
[MergeOption(MergeOption.Ignore)]
public string CommentId { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### LinkId
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/LinkInfo.cs#L17"
[YamlMember(Alias = "linkId")]
[MergeOption(MergeOption.MergeKey)]
[JsonPropertyName("linkId")]
public string LinkId { get; set; }
```   

#### Property Value
[string](https://learn.microsoft.com/dotnet/api/system.string)   
   
### LinkType
   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/LinkInfo.cs#L12"
[YamlMember(Alias = "linkType")]
[JsonPropertyName("linkType")]
[MergeOption(MergeOption.Ignore)]
public LinkType LinkType { get; set; }
```   

#### Property Value
[LinkType](../DocFxToTemplate.Models.DocFx/LinkType)   
   
   

   

   

   

   

   