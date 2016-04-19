using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars.Interfaces
{
    public class Predador : Species, IWarrior
    {
        private string[] _weapons = new string[2] { "Proton Cannon", "Plasma Grenade" };

        public override string Name { get { return "Predador"; } }

        public override string Color
        {
            get { return "Blue";}
        }

        public override int NumberOfArms
        {
            get { return 4;}
        }

        public override int Population
        {
            get; set;
        }

        public override string SpeciesDescription
        {
            get
            {
                return "A hardy and intelligent species that is cunning and calculated with a high degree of blood lust.";
            }
        }

        public override string[] Weapons
        {
            get { return _weapons; }
            set { _weapons = value; }
        }
        public override int NumberOfEyes
        {
            get { return 6; }
        }

        public override string TypeOfComics
        {
            get { return "Predator"; }
        }

        public override int NumberOfLegs
        {
            get { return 4; }
        }

        public string WarriorName
        {
            get { return "Benji"; }
        }

        public int AggressivenessLevel
        {
            get { return 9; }
        }


        public Predador(int population) : base(population)
        {
            Console.WriteLine("Predator species");
            Console.WriteLine("Weapons: " + String.Join(", ", Weapons));
        }
    }
}
