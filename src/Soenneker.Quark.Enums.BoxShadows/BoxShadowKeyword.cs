using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class BoxShadowEnum
{
    /// <summary>
    /// No shadow
    /// </summary>
    public static readonly BoxShadowEnum None = new("shadow-none");

    /// <summary>
    /// Extra small shadow
    /// </summary>
    public static readonly BoxShadowEnum Xs = new("shadow-xs");

    /// <summary>
    /// Small shadow
    /// </summary>
    public static readonly BoxShadowEnum Sm = new("shadow-sm");

    /// <summary>
    /// Default shadow
    /// </summary>
    public static readonly BoxShadowEnum Default = new("shadow");

    /// <summary>
    /// Medium shadow
    /// </summary>
    public static readonly BoxShadowEnum Md = new("shadow-md");

    /// <summary>
    /// Large shadow
    /// </summary>
    public static readonly BoxShadowEnum Lg = new("shadow-lg");

    /// <summary>
    /// Extra large shadow
    /// </summary>
    public static readonly BoxShadowEnum Xl = new("shadow-xl");

    /// <summary>
    /// 2x extra large shadow
    /// </summary>
    public static readonly BoxShadowEnum TwoXl = new("shadow-2xl");

    /// <summary>
    /// Inner shadow
    /// </summary>
    public static readonly BoxShadowEnum Inner = new("shadow-inner");
}
