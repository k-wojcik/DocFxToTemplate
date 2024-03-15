// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.Json.Serialization;
using DocFxToTemplate.Models.DocFx.Attributes;
using YamlDotNet.Serialization;

namespace DocFxToTemplate.Models.DocFx;

public class AdditionalNotes
{
    [YamlMember(Alias = "caller")]
    [JsonPropertyName("caller")]
    [MarkdownContent]
    public string Caller { get; set; }

    [YamlMember(Alias = "implementer")]
    [JsonPropertyName("implementer")]
    [MarkdownContent]
    public string Implementer { get; set; }

    [YamlMember(Alias = "inheritor")]
    [JsonPropertyName("inheritor")]
    [MarkdownContent]
    public string Inheritor { get; set; }
}