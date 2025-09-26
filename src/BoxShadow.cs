using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// An HTML CSS keyword set in .NET enumeration form
/// </summary>
[Intellenum<string>]
public partial class BoxShadow
{
    /// <summary>
    /// No shadow is displayed. This is the default value.
    /// </summary>
    public static readonly BoxShadow None = new("none");

    /// <summary>
    /// The shadow is drawn inside the element's border box, creating an inner shadow effect.
    /// This keyword can be used in combination with other box-shadow values.
    /// </summary>
    public static readonly BoxShadow Inset = new("inset");

    public static implicit operator BoxShadow(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}
