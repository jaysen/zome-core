
namespace Zomes.Core.Tests.Models;
public class ZomeTests
{
    [Fact]
    public void Zome_Creation()
    {
        // Act
        var zome = new Zome();

        // Assert
        zome.Nodes.Should().BeEmpty();
        zome.Links.Should().BeEmpty();
        zome.Tags.Should().BeEmpty();
    }

    // Add additional test cases for Zome class here
}
