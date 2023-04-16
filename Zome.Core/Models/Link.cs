using QuikGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zome.Core.Interfaces;

namespace Zome.Core.Models;

public class Link : Edge<Node>, ILink, ITaggable
{
    public INode Source { get; }
    public INode Target { get; }
    public double Weight { get; set; }
    public string LinkType { get; set; }
    public object Data { get; set; }
    public HashSet<Tag> Tags { get; set; }

    public Link(Node source, Node target) : base(source, target)
    {
        Tags = new HashSet<Tag>();
    }

    public void AddTag(Tag tag)
    {
        Tags.Add(tag);
    }

    public void RemoveTag(Tag tag)
    {
        Tags.Remove(tag);
    }

    public bool HasTag(Tag tag)
    {
        return Tags.Contains(tag);
    }
}