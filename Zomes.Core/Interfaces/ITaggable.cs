﻿using Zomes.Core.Models;

namespace Zomes.Core.Interfaces;

public interface ITaggable
{
    HashSet<ITag> Tags { get; set; }

    void AddTag(ITag tag);
    void RemoveTag(ITag tag);
    bool HasTag(ITag tag);
    List<ITag> GetAllTags(); // get tags as a list (for convenience)
}