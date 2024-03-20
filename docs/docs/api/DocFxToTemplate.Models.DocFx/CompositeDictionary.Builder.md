---
title: Class CompositeDictionary.Builder
sidebar_label: CompositeDictionary.Builder
description: TODO
---

# Class CompositeDictionary.Builder
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L172](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L172)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L172" 
public sealed class CompositeDictionary.Builder
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[CompositeDictionary.Builder](../DocFxToTemplate.Models.DocFx/CompositeDictionary.Builder)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

   

   

   

## Methods
### Add&lt;TValue&gt;(string, IDictionary&lt;string, TValue&gt;, Func&lt;object, TValue&gt;)
   
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L180"
public CompositeDictionary.Builder Add<TValue>(string prefix, IDictionary<string, TValue> dict, Func<object, TValue> valueConverter = null)
```

#### Parameters
`prefix` [string](https://learn.microsoft.com/dotnet/api/system.string)   
   
`dict` IDictionary&lt;string, TValue&gt;   
   
`valueConverter` Func&lt;object, TValue&gt;   
   
#### Returns
 [CompositeDictionary.Builder](../DocFxToTemplate.Models.DocFx/CompositeDictionary.Builder)    
   

### Create()
   
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L213"
public CompositeDictionary Create()
```

#### Returns
 [CompositeDictionary](../DocFxToTemplate.Models.DocFx/CompositeDictionary)    
   

   

   

   

   