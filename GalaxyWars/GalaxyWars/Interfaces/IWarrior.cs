using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars.Interfaces
{
    public interface IWarrior
    {
        string WarriorName { get; }

        int AggressivenessLevel { get; }
    }
}
