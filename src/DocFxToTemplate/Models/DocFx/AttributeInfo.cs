﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.Json.Serialization;
using DocFxToTemplate.Models.DocFx.Attributes;
using YamlDotNet.Serialization;

namespace DocFxToTemplate.Models.DocFx;

public class AttributeInfo
{
    [YamlMember(Alias = "type")]
    [JsonPropertyName("type")]
    [UniqueIdentityReference]
    public string Type { get; set; }

    [YamlMember(Alias = "ctor")]
    [JsonPropertyName("ctor")]
    public string Constructor { get; set; }

    [YamlMember(Alias = "arguments")]
    [JsonPropertyName("arguments")]
    public List<ArgumentInfo> Arguments { get; set; }

    [YamlMember(Alias = "namedArguments")]
    [JsonPropertyName("namedArguments")]
    public List<NamedArgumentInfo> NamedArguments { get; set; }
}