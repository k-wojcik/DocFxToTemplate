// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using DocFxToTemplate.Models.DocFx.Attributes;
using YamlDotNet.Serialization;

namespace DocFxToTemplate.Models.DocFx;

public class ApiParameter
{
    [YamlMember(Alias = "id")]
    [JsonPropertyName("id")]
    [MergeOption(MergeOption.MergeKey)]
    public string Name { get; set; }

    [YamlMember(Alias = "type")]
    [JsonPropertyName("type")]
    [UniqueIdentityReference]
    public string Type { get; set; }

    [YamlMember(Alias = "description")]
    [JsonPropertyName("description")]
    [MarkdownContent]
    public string Description { get; set; }

    [YamlMember(Alias = "attributes")]
    [JsonPropertyName("attributes")]
    [MergeOption(MergeOption.Ignore)]
    public List<AttributeInfo> Attributes { get; set; }
    
    [JsonIgnore]
    [YamlIgnore]
    [IgnoreDataMember]
    public ReferenceViewModel? Reference { get; set; } 
}