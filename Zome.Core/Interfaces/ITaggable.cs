using Zome.Core.Models;

namespace Zome.Core.Interfaces;


public interface ITaggable
{
    HashSet<ITag> Tags { get; set; }

    void AddTag(ITag tag);
    void RemoveTag(ITag tag);
    bool HasTag(ITag tag);
}