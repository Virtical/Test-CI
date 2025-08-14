using FluentAssertions;
using NUnit.Framework;

namespace TestProject.Test;

[TestFixture]
public class FirstTestShould
{
    [Test]
    public void AlwaysTrue()
    {
        const bool t = true;

        t.Should().BeTrue();
    }
}