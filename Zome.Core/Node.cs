using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zome.Core;

public class Node
{
    public int Id { get; set; }
    public string Name { get; set; }
    public object Data { get; set; }
    public HashSet<Tag> Tags { get; set; }

    public Node(int id, string name, object? data = null)
    {
        Id = id;
        Name = name;
        Data = data;
        Tags = new HashSet<Tag>();
    }

    public override string ToString()
    {
        return Name;
    }
}