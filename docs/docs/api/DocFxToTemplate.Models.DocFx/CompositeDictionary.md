---
title: Class CompositeDictionary
sidebar_label: CompositeDictionary
description: TODO
---

# Class CompositeDictionary
Namespace: DocFxToTemplate.Models.DocFx   
Assembly: DocFxToTemplate.dll  
Source: [src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L9](https://github.com/k-wojcik/DocFxToTemplate/blob/master/src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L9)    
   

```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L9" 
public class CompositeDictionary : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
```

**Inheritance:**   
[object](https://learn.microsoft.com/dotnet/api/system.object) &lt;- 
[CompositeDictionary](../DocFxToTemplate.Models.DocFx/CompositeDictionary)   

**Inherited Members:**   
[object.Equals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object-system-object)), [object.Equals(object)](https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)), [object.GetHashCode()](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), [object.GetType()](https://learn.microsoft.com/dotnet/api/system.object.gettype), [object.MemberwiseClone()](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), [object.ReferenceEquals(object, object)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), [object.ToString()](https://learn.microsoft.com/dotnet/api/system.object.tostring)   

**Implements:**   
System.Collections.Generic.ICollection\<System.Collections.Generic.KeyValuePair\<System.String,System.Object\>\>, System.Collections.Generic.IDictionary\<System.String,System.Object\>, System.Collections.Generic.IEnumerable\<System.Collections.Generic.KeyValuePair\<System.String,System.Object\>\>, System.Collections.IEnumerable   

## Properties
### this[string]
Gets or sets the element with the specified key.   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L24"
public object this[string key] { get; set; }
```   

#### Property value
[object](https://learn.microsoft.com/dotnet/api/system.object)   
The element with the specified key.   
### Count
Gets the number of elements contained in the System.Collections.Generic.ICollection%601.   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L55"
public int Count { get; }
```   

#### Property value
[int](https://learn.microsoft.com/dotnet/api/system.int32)   
The number of elements contained in the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref>.   
### IsReadOnly
Gets a value indicating whether the System.Collections.Generic.ICollection%601 is read-only.   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L57"
public bool IsReadOnly { get; }
```   

#### Property value
[bool](https://learn.microsoft.com/dotnet/api/system.boolean)   
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> is read-only; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.   
### Keys
Gets an System.Collections.Generic.ICollection%601 containing the keys of the System.Collections.Generic.IDictionary%602.   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L59"
public ICollection<string> Keys { get; }
```   

#### Property value
[ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1)&lt;[string](https://learn.microsoft.com/dotnet/api/system.string)&gt;   
An <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> containing the keys of the object that implements <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref>.   
### Values
Gets an System.Collections.Generic.ICollection%601 containing the values in the System.Collections.Generic.IDictionary%602.   
            
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L61"
public ICollection<object> Values { get; }
```   

#### Property value
[ICollection](https://learn.microsoft.com/dotnet/api/system.collections.generic.icollection-1)&lt;[object](https://learn.microsoft.com/dotnet/api/system.object)&gt;   
An <xref href="System.Collections.Generic.ICollection%601" data-throw-if-not-resolved="false"></xref> containing the values in the object that implements <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref>.   
   

   

## Methods
### Add(string, object)
Adds an element with the provided key and value to the System.Collections.Generic.IDictionary%602.   
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L68"
public void Add(string key, object value)
```

#### Parameters
`key` [string](https://learn.microsoft.com/dotnet/api/system.string)   
The object to use as the key of the element to add.   
`value` [object](https://learn.microsoft.com/dotnet/api/system.object)   
The object to use as the value of the element to add.   

### Clear()
Removes all items from the System.Collections.Generic.ICollection%601.   
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L82"
public void Clear()
```


### ContainsKey(string)
Determines whether the System.Collections.Generic.IDictionary%602 contains an element with the specified key.   
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L92"
public bool ContainsKey(string key)
```

#### Parameters
`key` [string](https://learn.microsoft.com/dotnet/api/system.string)   
The key to locate in the <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref>.   
#### Returns
 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)    
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref> contains an element with the key; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.   

### GetEnumerator()
Returns an enumerator that iterates through the collection.   
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L111"
public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
```

#### Returns
 IEnumerator&lt;KeyValuePair&lt;string, object&gt;&gt;    
An enumerator that can be used to iterate through the collection.   

### Remove(string)
Removes the element with the specified key from the System.Collections.Generic.IDictionary%602.   
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L124"
public bool Remove(string key)
```

#### Parameters
`key` [string](https://learn.microsoft.com/dotnet/api/system.string)   
The key of the element to remove.   
#### Returns
 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)    
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the element is successfully removed; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.  This method also returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a> if <code class="paramref">key</code> was not found in the original <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref>.   

### TryGetValue(string, out object)
Gets the value associated with the specified key.   
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L134"
public bool TryGetValue(string key, out object value)
```

#### Parameters
`key` [string](https://learn.microsoft.com/dotnet/api/system.string)   
The key whose value to get.   
`value` [object](https://learn.microsoft.com/dotnet/api/system.object)   
When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <code class="paramref">value</code> parameter. This parameter is passed uninitialized.   
#### Returns
 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)    
<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the object that implements <xref href="System.Collections.Generic.IDictionary%602" data-throw-if-not-resolved="false"></xref> contains an element with the specified key; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.   

### CreateBuilder()
   
```csharp title="src/DocFxToTemplate/Models/DocFx/CompositeDictionary.cs#L155"
public static CompositeDictionary.Builder CreateBuilder()
```

#### Returns
 [CompositeDictionary.Builder](../DocFxToTemplate.Models.DocFx/CompositeDictionary.Builder)    
   

   

   

## Implements
* System.Collections.Generic.ICollection\<System.Collections.Generic.KeyValuePair\<System.String,System.Object\>\>
* System.Collections.Generic.IDictionary\<System.String,System.Object\>
* System.Collections.Generic.IEnumerable\<System.Collections.Generic.KeyValuePair\<System.String,System.Object\>\>
* System.Collections.IEnumerable
   

   