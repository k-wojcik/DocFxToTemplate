// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.Json.Serialization;
using YamlDotNet.Serialization;

namespace DocFxToTemplate.Models.DocFx;

public class SourceDetail
{
    [YamlMember(Alias = "remote")]
    [JsonPropertyName("remote")]
    public GitDetail Remote { get; set; }

    [YamlMember(Alias = "id")]
    [JsonPropertyName("id")]
    public string Name { get; set; }

    /// <summary>
    ///     The url path for current source, should be resolved at some late stage
    /// </summary>
    [YamlMember(Alias = Constants.PropertyName.Href)]
    [JsonPropertyName(Constants.PropertyName.Href)]
    public string Href { get; set; }

    /// <summary>
    ///     The local path for current source, should be resolved to be relative path at some late stage
    /// </summary>
    [YamlMember(Alias = "path")]
    [JsonPropertyName("path")]
    public string Path { get; set; }

    [YamlMember(Alias = "startLine")]
    [JsonPropertyName("startLine")]
    public int StartLine { get; set; }

    [YamlMember(Alias = "endLine")]
    [JsonPropertyName("endLine")]
    public int EndLine { get; set; }
}