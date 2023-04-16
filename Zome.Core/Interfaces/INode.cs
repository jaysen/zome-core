using Zome.Core.Models;

namespace Zome.Core.Interfaces;

public interface INode : ITaggable
{
    Guid Id { get; }
    string Label { get; set; }
    object Data { get; set; }
}