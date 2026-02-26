using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An HTML CSS keyword set in .NET enumeration form
/// </summary>
[EnumValue<string>]
public partial class BoxShadowKeyword
{
    /// <summary>
    /// No shadow is displayed. This is the default value.
    /// </summary>
    public static readonly BoxShadowKeyword None = new("none");

    /// <summary>
    /// The shadow is drawn inside the element's border box, creating an inner shadow effect.
    /// This keyword can be used in combination with other box-shadow values.
    /// </summary>
    public static readonly BoxShadowKeyword Inset = new("inset");

    public static implicit operator BoxShadowKeyword(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}
