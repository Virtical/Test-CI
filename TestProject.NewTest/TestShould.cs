using FluentAssertions;
using NUnit.Framework;

namespace TestProject.NewTest;

[TestFixture]
public class TestShould
{
    [Test]
    public void AlwaysFalse()
    {
        const bool f = false;

        f.Should().BeFalse();
    }
}