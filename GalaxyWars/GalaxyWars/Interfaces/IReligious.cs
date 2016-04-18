using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars.Interfaces
{
    public interface IReligious
    {
        string ReligionName { get; }
        //Can change later.  Needed to get 2 more properties.
        int FaithLevel { get; }

    }
}
