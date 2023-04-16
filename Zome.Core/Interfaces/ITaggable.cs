using System;
using Zome.Core.Models;

namespace Zome.Core.Interfaces;


public interface ITaggable
{
    HashSet<Tag> Tags { get; set; }

    void AddTag(Tag tag);
    void RemoveTag(Tag tag);
    bool HasTag(Tag tag);
}