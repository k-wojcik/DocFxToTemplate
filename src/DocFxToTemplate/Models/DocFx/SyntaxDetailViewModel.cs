// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.Json.Serialization;
using DocFxToTemplate.Models.DocFx.Attributes;
using YamlDotNet.Serialization;

namespace DocFxToTemplate.Models.DocFx;

public class SyntaxDetailViewModel
{
    [YamlMember(Alias = Constants.PropertyName.Content)]
    [JsonPropertyName(Constants.PropertyName.Content)]
    public string Content { get; set; }

    [ExtensibleMember(Constants.ExtensionMemberPrefix.Content)]
    [JsonIgnore]
    public SortedList<string, string> Contents { get; set; } = new();

    [YamlIgnore]
    [JsonIgnore]
    public string ContentForCSharp
    {
        get
        {
            Contents.TryGetValue("csharp", out var result);
            return result;
        }
        set
        {
            if (value == null)
                Contents.Remove("csharp");
            else
                Contents["csharp"] = value;
        }
    }

    [YamlIgnore]
    [JsonIgnore]
    public string ContentForVB
    {
        get
        {
            Contents.TryGetValue("vb", out var result);
            return result;
        }
        set
        {
            if (value == null)
                Contents.Remove("vb");
            else
                Contents["vb"] = value;
        }
    }

    [YamlMember(Alias = "parameters")]
    [JsonPropertyName("parameters")]
    public List<ApiParameter>? Parameters { get; set; }

    [YamlMember(Alias = "typeParameters")]
    [JsonPropertyName("typeParameters")]
    public List<ApiParameter>? TypeParameters { get; set; }

    [YamlMember(Alias = "return")]
    [JsonPropertyName("return")]
    public ApiParameter? Return { get; set; }

    // [EditorBrowsable(EditorBrowsableState.Never)]
    // [YamlIgnore]
    // 
    // [System.Text.Json.Serialization.JsonExtensionData]
    // [UniqueIdentityReferenceIgnore]
    // [MarkdownContentIgnore]
    // public IDictionary<string, object> ExtensionData =>
    //     CompositeDictionary
    //         .CreateBuilder()
    //         .Add(Constants.ExtensionMemberPrefix.Content, Contents, JTokenConverter.Convert<string>)
    //         .Create();
}