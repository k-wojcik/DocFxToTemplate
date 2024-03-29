﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.Json.Serialization;
using DocFxToTemplate.Models.DocFx.Attributes;
using YamlDotNet.Serialization;

namespace DocFxToTemplate.Models.DocFx;

public class NamedArgumentInfo
{
    [YamlMember(Alias = "name")]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [YamlMember(Alias = "type")]
    [JsonPropertyName("type")]
    [UniqueIdentityReference]
    public string Type { get; set; }

    [YamlMember(Alias = "value")]
    [JsonPropertyName("value")]
    public object Value { get; set; }
}