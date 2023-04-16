using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zomes.Core.Interfaces;

namespace Zomes.Core.Models;

public class Node : INode, ITaggable
{
    public Guid Id { get; }
    public string Label { get; set; }
    public object Data { get; set; }

    public HashSet<ITag> Tags { get; set; }

    public Node(string label)
    {
        Id = Guid.NewGuid();
        Label = label;
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

    public List<ITag> GetAllTags()
    {
        return Tags.ToList();
    }

}