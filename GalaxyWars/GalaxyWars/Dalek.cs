using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars.Interfaces
{
    public class Dalek : Species, ISpacefaring
    {
        private string[] _weapons = new string[2] { "Laser Gun", "Electric Drill" };

        public override string Color
        {
            get { return "Grey"; }
        }

        public override int NumberOfArms
        {
            get { return 3; }
        }

        public override int Population
        {
            get; set;
        }

        public override string SpeciesDescription
        {
            get
            {
                return "A robot-like species that seeks only death and destruction.  " +
                    "An immense hatred of someone called Doctor Who.";
            }
        }

        public override string[] Weapons
        {
            get { return _weapons; }
            set { _weapons = value; }
        }

        public Dalek(int population) : base(population)
        {
        }
    }
}
