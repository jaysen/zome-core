using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using QuikGraph;
using QuikGraph.Algorithms;

namespace ZomeCore;

public class Zome : BidirectionalGraph<Node, ZomeEdge>
{
    public Dictionary<string, Tag> Tags { get; set; }

    public Zome() : base()
    {
        Tags = new Dictionary<string, Tag>();
    }

    // Add methods for set operations, searching, and other manipulations here
}


public class Node
{
    public int Id { get; set; }
    public string Name { get; set; }
    public object Data { get; set; }
    public HashSet<Tag> Tags { get; set; }

    public Node(int id, string name, object? data = null)
    {
        Id = id;
        Name = name;
        Data = data;
        Tags = new HashSet<Tag>();
    }

    public override string ToString()
    {
        return Name;
    }
}

public class ZomeEdge : Edge<Node>
{
    public double Weight { get; set; }
    public HashSet<string> ConnectionTypes { get; set; }
    public object Data { get; set; }
    public HashSet<Tag> Tags { get; set; }

    public ZomeEdge(Node source, Node target, double weight, object data = null)
        : base(source, target)
    {
        Weight = weight;
        ConnectionTypes = new HashSet<string>();
        Data = data;
        Tags = new HashSet<Tag>();
    }
}

public class Tag
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Tag(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
