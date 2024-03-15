using Scriban;
using Scriban.Syntax;

namespace DocFxToTemplate.Scriban;

internal static class TemplateContextExtensions
{
    public static GeneratorContext GetGeneratorContext(this TemplateContext context)
    {
        return (GeneratorContext)context.GetValue(new ScriptVariableGlobal("generator_context"));
    }
}