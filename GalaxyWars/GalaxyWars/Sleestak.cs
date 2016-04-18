using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars.Interfaces
{
    class Sleestak : Species, IReligious
    {
        private string[] _weapons = new string[2] { "Crossbow", "Sharp Stick" };

        public override string Color
        {
            get { return "Green"; }
        }

        public override int NumberOfArms
        {
            get { return 2; }
        }

        public override int Population
        {
            get; set;
        }

        public override string SpeciesDescription
        {
            get
            {
                return "A reptilian bipedal humanoid species. They have a thin but wide-set mouths and large, round black eyes that are averse to light. Covered mostly in green scales, their bellies are yellow.";
            }
        }

        public override string[] Weapons
        {
            get { return _weapons; }
            set { _weapons = value; }
        }

        public override int NumberOfEyes
        {
            get { return 2; }
        }

        public override string TypeOfComics
        {
            get { return "Fraggle Rock"; }
        }

        public override int NumberOfLegs
        {
            get { return 2; }
        }

        public string ReligionName
        {
            get { return "Sovereignty"; }
        }

        public Sleestak(int population) : base(population)
        {
        }
    }
}
