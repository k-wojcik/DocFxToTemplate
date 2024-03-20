---
title: Class TemplateLoader
sidebar_label: TemplateLoader
description: TODO
---

# Class TemplateLoader
Namespace: DocFxToTemplate.Templates   
Assembly: DocFxToTemplate.dll
    
   

```csharp title="src/DocFxToTemplate/Templates/TemplateLoader.cs#6" 
public class TemplateLoader : ITemplateLoader
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[TemplateLoader](../DocFxToTemplate.Templates/TemplateLoader)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

**Implements:**   
Scriban.Runtime.ITemplateLoader   

   

   

## Methods
### GetPath(TemplateContext, SourceSpan, string)
Gets an absolute path for the specified include template name. Note that it is not necessarely a path on a disk,
but an absolute path that can be used as a dictionary key for caching)   

#### Parameters
`context` TemplateContext   
The current context called from   
`callerSpan` SourceSpan   
The current span called from   
`templateName` [string](https://learn.microsoft.com/dotnet/api/system.string)   
The name of the template to load   
#### Returns
 [string](https://learn.microsoft.com/dotnet/api/system.string)    
An absolute path or unique key for the specified template name   

### Load(TemplateContext, SourceSpan, string)
Loads a template using the specified template path/key.   

#### Parameters
`context` TemplateContext   
The current context called from   
`callerSpan` SourceSpan   
The current span called from   
`templatePath` [string](https://learn.microsoft.com/dotnet/api/system.string)   
The path/key previously returned by <xref href="Scriban.Runtime.ITemplateLoader.GetPath(Scriban.TemplateContext%2cScriban.Parsing.SourceSpan%2cSystem.String)" data-throw-if-not-resolved="false"></xref>   
#### Returns
 [string](https://learn.microsoft.com/dotnet/api/system.string)    
The content string loaded from the specified template path/key   

### LoadAsync(TemplateContext, SourceSpan, string)
Loads a template using the specified template path/key.   

#### Parameters
`context` TemplateContext   
The current context called from   
`callerSpan` SourceSpan   
The current span called from   
`templatePath` [string](https://learn.microsoft.com/dotnet/api/system.string)   
The path/key previously returned by <xref href="Scriban.Runtime.ITemplateLoader.GetPath(Scriban.TemplateContext%2cScriban.Parsing.SourceSpan%2cSystem.String)" data-throw-if-not-resolved="false"></xref>   
#### Returns
 ValueTask&lt;string&gt;    
The content string loaded from the specified template path/key   

   

   

## Implements
* Scriban.Runtime.ITemplateLoader
   

   