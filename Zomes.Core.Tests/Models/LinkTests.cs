using Xunit;
using FluentAssertions;
using Zomes.Core.Models;

namespace Zomes.Core.Tests.Models;

public class LinkTests
{
    [Fact]
    public void LinkConstructor_CreatesLinkWithCorrectSourceAndTarget()
    {
        // Arrange
        var source = new Node("Source");
        var target = new Node("Target");

        // Act
        var link = new Link(source, target);

        // Assert
        link.Source.Should().Be(source);
        link.Target.Should().Be(target);
    }

    [Fact]
    public void AddTag_AddsTagToLink()
    {
        // Arrange
        var link = new Link(new Node("Source"), new Node("Target"));
        var tag = new Tag("Tag1", "Description");

        // Act
        link.AddTag(tag);

        // Assert
        link.Tags.Should().Contain(tag);
    }

    [Fact]
    public void RemoveTag_RemovesTagFromLink()
    {
        // Arrange
        var link = new Link(new Node("Source"), new Node("Target"));
        var tag = new Tag("Tag1", "Description");
        link.AddTag(tag);

        // Act
        link.RemoveTag(tag);

        // Assert
        link.Tags.Should().NotContain(tag);
    }

    [Fact]
    public void HasTag_ReturnsTrue_WhenTagExistsInLink()
    {
        // Arrange
        var link = new Link(new Node("Source"), new Node("Target"));
        var tag = new Tag("Tag1", "Description");
        link.AddTag(tag);

        // Act
        var hasTag = link.HasTag(tag);

        // Assert
        hasTag.Should().BeTrue();
    }

    [Fact]
    public void GetAllTags_ReturnsListOfTags()
    {
        // Arrange
        var link = new Link(new Node("Source"), new Node("Target"));
        var tag1 = new Tag("Tag1", "Description1");
        var tag2 = new Tag("Tag2", "Description2");
        link.AddTag(tag1);
        link.AddTag(tag2);

        // Act
        var allTags = link.GetAllTags();

        // Assert
        allTags.Should().HaveCount(2).And.Contain(new[] { tag1, tag2 });
    }
}
