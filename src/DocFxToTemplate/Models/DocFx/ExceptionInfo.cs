// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.Json.Serialization;
using DocFxToTemplate.Models.DocFx.Attributes;
using YamlDotNet.Serialization;

namespace DocFxToTemplate.Models.DocFx;

public class ExceptionInfo
{
    [YamlMember(Alias = "type")]
    [MergeOption(MergeOption.MergeKey)]
    [JsonPropertyName("type")]
    [UniqueIdentityReference]
    public string Type { get; set; }

    [YamlMember(Alias = Constants.PropertyName.CommentId)]
    [JsonPropertyName(Constants.PropertyName.CommentId)]
    public string CommentId { get; set; }

    [YamlMember(Alias = "description")]
    [JsonPropertyName("description")]
    [MarkdownContent]
    public string Description { get; set; }

    internal ExceptionInfo Clone()
    {
        return (ExceptionInfo)MemberwiseClone();
    }
}