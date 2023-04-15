using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using QuikGraph;

namespace Zome.Core;

public class Zome : BidirectionalGraph<Node, ZomeEdge>
{
    public Dictionary<string, Tag> Tags { get; set; }

    public Zome() : base()
    {
        Tags = new Dictionary<string, Tag>();
    }

    // Add methods for set operations, searching, and other manipulations here
}