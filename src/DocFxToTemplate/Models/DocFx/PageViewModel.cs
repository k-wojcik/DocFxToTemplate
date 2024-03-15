// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.Json.Serialization;
using YamlDotNet.Serialization;

namespace DocFxToTemplate.Models.DocFx;

public class PageViewModel
{
    [YamlMember(Alias = "items")]
    [JsonPropertyName("items")]
    public List<ItemViewModel> Items { get; set; } = new();

    [YamlMember(Alias = "references")]
    [JsonPropertyName("references")]
    public List<ReferenceViewModel> References { get; set; } = new();

    [YamlMember(Alias = "shouldSkipMarkup")]
    [JsonPropertyName("shouldSkipMarkup")]
    public bool ShouldSkipMarkup { get; set; }


    [JsonExtensionData] public Dictionary<string, object> Metadata { get; set; } = new();
}