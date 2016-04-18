using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars.Interfaces
{
    interface ISpecies
    {
        int Population { get; set; }
        string SpeciesDescription { get; }
        int NumberOfArms { get; }
        string Color { get; }
        String[] Weapons { get; set; }
    }
}
