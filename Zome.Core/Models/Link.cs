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
    public double Weight { get; set; }
    public string LinkType { get; set; }
    public object Data { get; set; }
    public HashSet<ITag> Tags { get; set; }

    public Link(Node source, Node target) : base(source, target)
    {
        Tags = new HashSet<ITag>();
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