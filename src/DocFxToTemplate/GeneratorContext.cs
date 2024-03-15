using DocFxToTemplate.Models.DocFx;

namespace DocFxToTemplate;

internal record GeneratorContext
{
    public required GeneratorOptions Options { get; init; }
    public required List<ItemViewModel> Items { get; init; }
}