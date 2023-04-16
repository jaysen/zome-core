using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zome.Core.Interfaces;

namespace Zome.Core.Models;

public class Node : INode, ITaggable
{
    public Guid Id { get; }
    public string Label { get; set; }
    public object Data { get; set; }

    public HashSet<Tag> Tags { get; set; }

    public Node(string label)
    {
        Id = Guid.NewGuid();
        Label = label;
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