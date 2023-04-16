

namespace Zomes.Core.Tests.Models;

public class NodeTests
{
    [Fact]
    public void Node_Should_Have_Default_Tags_Set()
    {
        // Arrange
        var node = new Node("test");

        // Assert
        node.Tags.Should().NotBeNull();
        node.Tags.Should().BeEmpty();
    }

    [Fact]
    public void Node_Should_Add_And_Remove_Tags()
    {
        // Arrange
        var node = new Node("test");
        var tag1 = new Tag("tag1", "Test tag 1");
        var tag2 = new Tag("tag2", "Test tag 2");

        // Act
        node.AddTag(tag1);
        node.AddTag(tag2);

        // Assert
        node.Tags.Should().HaveCount(2);
        node.Tags.Should().Contain(tag1);
        node.Tags.Should().Contain(tag2);

        // Act
        node.RemoveTag(tag1);

        // Assert
        node.Tags.Should().HaveCount(1);
        node.Tags.Should().NotContain(tag1);
        node.Tags.Should().Contain(tag2);
    }

    [Fact]
    public void Node_Should_Check_If_Has_Tags()
    {
        // Arrange
        var node = new Node("test");
        var tag1 = new Tag("tag1", "Test tag 1");
        var tag2 = new Tag("tag2", "Test tag 2");

        // Act
        node.AddTag(tag1);

        // Assert
        node.HasTag(tag1).Should().BeTrue();
        node.HasTag(tag2).Should().BeFalse();
    }

    [Fact]
    public void Node_Should_Get_All_Tags()
    {
        // Arrange
        var node = new Node("test");
        var tag1 = new Tag("tag1", "Test tag 1");
        var tag2 = new Tag("tag2", "Test tag 2");

        // Act
        node.AddTag(tag1);
        node.AddTag(tag2);
        var allTags = node.GetAllTags();

        // Assert
        allTags.Should().HaveCount(2);
        allTags.Should().Contain(tag1);
        allTags.Should().Contain(tag2);
    }
}
