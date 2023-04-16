using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zome.Core.Interfaces;

namespace Zome.Core.Models;

public class Tag : ITag
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Tag(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
