namespace DocFxToTemplate;

public class GeneratorOptions
{
    public required string YamlPath { get; set; } 
    public required string OutputPath { get; set; }
    
    public string IndexSlug { get; set; } = "/api";
}