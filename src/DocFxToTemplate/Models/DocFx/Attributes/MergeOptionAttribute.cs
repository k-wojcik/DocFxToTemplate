namespace DocFxToTemplate.Models.DocFx.Attributes;

public class MergeOptionAttribute : Attribute
{
    public MergeOptionAttribute(MergeOption option)
    {
    }
}

public enum MergeOption
{
    MergeKey,
    Ignore,
    Replace
}