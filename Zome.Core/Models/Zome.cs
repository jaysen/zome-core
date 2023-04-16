using System.Collections.Generic;
using System.Linq;
using QuikGraph;
using Zome.Core.Interfaces;

namespace Zome.Core.Models;

public class Zome : IZome, ITaggable
{
    public HashSet<ITag> Tags { get; set; }
    public HashSet<INode> Nodes { get; set; }
    public HashSet<ILink> Links { get; set; }

    public Zome()
    {
        Tags = new HashSet<ITag>();
        Nodes = new HashSet<INode>();
        Links = new HashSet<ILink>();
    }

    public void AddNode(INode node)
    {
        Nodes.Add(node);
    }

    public void RemoveNode(INode node)
    {
        Nodes.Remove(node);
    }

    public bool HasNode(INode node)
    {
        return Nodes.Contains(node);
    }

    public void AddLink(ILink link)
    {
        Links.Add(link);
    }

    public void RemoveLink(ILink link)
    {
        Links.Remove(link);
    }

    public bool HasLink(ILink link)
    {
        return Links.Contains(link);
    }

    public bool IsConnected(INode node1, INode node2)
    {
        return Links.Any(l => (l.Source == node1 && l.Target == node2) || (l.Source == node2 && l.Target == node1));
    }

    public List<INode> GetNeighbors(INode node)
    {
        var neighbors = new List<INode>();
        foreach (var link in Links)
        {
            if (link.Source == node)
            {
                neighbors.Add(link.Target);
            }
            else if (link.Target == node)
            {
                neighbors.Add(link.Source);
            }
        }
        return neighbors;
    }

    public ILink GetLink(INode node1, INode node2)
    {
        return Links.FirstOrDefault(l => (l.Source == node1 && l.Target == node2) || (l.Source == node2 && l.Target == node1));
    }

    public List<ILink> GetLinks(INode node)
    {
        return Links.Where(l => l.Source == node || l.Target == node).ToList();
    }

    public List<INode> GetNodesWithTag(Tag tag)
    {
        var nodes = new List<INode>();
        foreach (var node in Nodes)
        {
            if (node.HasTag(tag))
            {
                nodes.Add(node);
            }
        }
        return nodes;
    }

    public List<ILink> GetLinksWithTag(Tag tag)
    {
        var links = new List<ILink>();
        foreach (var link in Links)
        {
            if (link.HasTag(tag))
            {
                links.Add(link);
            }
        }
        return links;
    }

    public List<INode> FindShortestPath(INode startNode, INode endNode)
    {
        // code to find shortest path
        return null;
    }

    public List<INode> FindWeightedShortestPath(INode startNode, INode endNode)
    {
        // code to find weighted shortest path
        return null;
    }

    public void AddTag(ITag tag)
    {
        Tags.Add(tag);
    }

    public void RemoveTag(ITag tag)
    {
        Tags.Remove(tag);
    }

    public bool HasTag(ITag tag)
    {
        return Tags.Contains(tag);
    }
}
