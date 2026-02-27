using AwesomeAssertions;
using Soenneker.Tests.Unit;
using Xunit;

namespace Soenneker.Quark.Enums.BoxShadows.Tests;

public sealed class BoxShadowTests : UnitTest
{
    [Fact]
    public void Default()
    {
    }

    [Fact]
    public void Composition_works()
    {
        BoxShadowKeyword.Inset.Value.Should()
                        .Be("inset");
    }
}