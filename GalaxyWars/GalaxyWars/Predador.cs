using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars.Interfaces
{
    public class Predador : Species, IWarrior
    {
        private string[] _weapons = new string[2] { "Laser Gun", "Electric Drill" };

        public override string Color
        {
            get { return "Red";}
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
                return "";
            }
        }

        public override string[] Weapons
        {
            get { return _weapons; }
            set { _weapons = value; }
        }

        public Predador(int population) : base(population)
        {
            Console.WriteLine("Predator species");
            Console.WriteLine("Weapons: " + String.Join(", ", Weapons));
        }
    }
}
