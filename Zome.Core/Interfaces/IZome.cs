using System.Collections.Generic;
using Zome.Core.Models;

namespace Zome.Core.Interfaces;

public interface IZome
{
    HashSet<ITag> Tags { get; set; }
    HashSet<INode> Nodes { get; set; }
    HashSet<ILink> Links { get; set; }

    void AddNode(INode node);
    void RemoveNode(INode node);
    bool HasNode(INode node);

    void AddLink(ILink link);
    void RemoveLink(ILink link);
    bool HasLink(ILink link);

    bool IsConnected(INode node1, INode node2);
    List<INode> GetNeighbors(INode node);
    ILink GetLink(INode node1, INode node2);
    List<ILink> GetLinks(INode node);

    List<INode> GetNodesWithTag(Tag tag);
    List<ILink> GetLinksWithTag(Tag tag);

    List<INode> FindShortestPath(INode startNode, INode endNode);
    List<INode> FindWeightedShortestPath(INode startNode, INode endNode);

    void AddTag(ITag tag);
    void RemoveTag(ITag tag);
    bool HasTag(ITag tag);
}
