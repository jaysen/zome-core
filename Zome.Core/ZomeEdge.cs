using QuikGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zome.Core;


public class ZomeEdge : Edge<Node>
{
    public double Weight { get; set; }
    public HashSet<string> ConnectionTypes { get; set; }
    public object Data { get; set; }
    public HashSet<Tag> Tags { get; set; }

    public ZomeEdge(Node source, Node target, double weight, object data = null)
        : base(source, target)
    {
        Weight = weight;
        ConnectionTypes = new HashSet<string>();
        Data = data;
        Tags = new HashSet<Tag>();
    }
}