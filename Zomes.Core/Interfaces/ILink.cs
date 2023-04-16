using QuikGraph;
using Zomes.Core.Interfaces;
using Zomes.Core.Models;

namespace Zomes.Core.Interfaces;


public interface ILink : IEdge<INode>, ITaggable
{
    double Weight { get; set; }
    string LinkType { get; set; }
    object Data { get; set; }

}
