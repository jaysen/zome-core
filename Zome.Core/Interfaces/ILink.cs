using QuikGraph;
using Zome.Core.Models;

namespace Zome.Core.Interfaces;


public interface ILink : IEdge<Node>, ITaggable
{
    double Weight { get; set; }
    string LinkType { get; set; }
    object Data { get; set; }

}
