
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

    [Fact]
    public void AddNode_AddsNodeToZome()
    {
        // Arrange
        var zome = new Zome();
        var node = new Node("Example");

        // Act
        zome.AddNode(node);

        // Assert
        zome.Nodes.Should().Contain(node);
    }

    [Fact]
    public void RemoveNode_RemovesNodeFromZome()
    {
        // Arrange
        var zome = new Zome();
        var node = new Node("Example");
        zome.AddNode(node);

        // Act
        zome.RemoveNode(node);

        // Assert
        zome.Nodes.Should().NotContain(node);
    }

    [Fact]
    public void HasNode_ReturnsTrue_WhenNodeExistsInZome()
    {
        // Arrange
        var zome = new Zome();
        var node = new Node("Example");
        zome.AddNode(node);

        // Act
        var hasNode = zome.HasNode(node);

        // Assert
        hasNode.Should().BeTrue();
    }

    [Fact]
    public void AddLink_AddsLinkToZome()
    {
        // Arrange
        var zome = new Zome();
        var source = new Node("Source");
        var target = new Node("Target");
        var link = new Link(source, target);

        // Act
        zome.AddLink(link);

        // Assert
        zome.Links.Should().Contain(link);
    }

    [Fact]
    public void RemoveLink_RemovesLinkFromZome()
    {
        // Arrange
        var zome = new Zome();
        var source = new Node("Source");
        var target = new Node("Target");
        var link = new Link(source, target);
        zome.AddLink(link);

        // Act
        zome.RemoveLink(link);

        // Assert
        zome.Links.Should().NotContain(link);
    }

    [Fact]
    public void HasLink_ReturnsTrue_WhenLinkExistsInZome()
    {
        // Arrange
        var zome = new Zome();
        var source = new Node("Source");
        var target = new Node("Target");
        var link = new Link(source, target);
        zome.AddLink(link);

        // Act
        var hasLink = zome.HasLink(link);

        // Assert
        hasLink.Should().BeTrue();
    }

    [Fact]
    public void IsConnected_ReturnsTrue_WhenNodesAreConnected()
    {
        // Arrange
        var zome = new Zome();
        var node1 = new Node("Node1");
        var node2 = new Node("Node2");
        var link = new Link(node1, node2);
        zome.AddLink(link);

        // Act
        var isConnected = zome.IsConnected(node1, node2);

        // Assert
        isConnected.Should().BeTrue();
    }

    [Fact]
    public void GetNeighbors_ReturnsListOfNeighbors()
    {
        // Arrange
        var zome = new Zome();
        var node1 = new Node("Node1");
        var node2 = new Node("Node2");
        var node3 = new Node("Node3");
        var link1 = new Link(node1, node2);
        var link2 = new Link(node1, node3);
        zome.AddLink(link1);
        zome.AddLink(link2);

        // Act
        var neighbors = zome.GetNeighbors(node1);

        // Assert
        neighbors.Should().HaveCount(2).And.Contain(new[] { node2, node3 });
    }

    [Fact]
    public void FindShortestPath_ReturnsShortestPathBetweenTwoNodes()
    {
        // Arrange
        var zome = new Zome();
        var node1 = new Node("Node1");
        var node2 = new Node("Node2");
        var node3 = new Node("Node3");
        var node4 = new Node("Node4");
        var link1 = new Link(node1, node2);
        var link2 = new Link(node2, node3);
        var link3 = new Link(node1, node3);
        var link4 = new Link(node3, node4);
        zome.AddLink(link1);
        zome.AddLink(link2);
        zome.AddLink(link3);
        zome.AddLink(link4);

        // Act
        var shortestPath = zome.FindShortestPath(node1, node4);

        // Assert
        shortestPath.Should().HaveCount(2).And.ContainInOrder(new[] { link3, link4 });
    }

    // Add more test cases for Zome class here, including tests for:
    // - GetLink
    // - GetLinks
    // - GetNodesWithTag
    // - GetLinksWithTag
    // - FindShortestPath
    // - FindWeightedShortestPath
    // - AddTag
    // - RemoveTag
    // - HasTag
    // - GetAllTags
}
