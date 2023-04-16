using QuikGraph;
using Zome.Core.Models;

namespace Zome.Core.Interfaces;


public interface ILink : IEdge<INode>, ITaggable
{
    INode Source { get; }
    INode Target { get; }
    double Weight { get; set; }
    string LinkType { get; set; }
    object Data { get; set; }

}
