using GalaxyWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
    public class Species : ISpecies
    {
        public virtual string Name
        {
            get;
        }

        public virtual string Color
        {
            get;
        }

        public virtual int NumberOfArms
        {
            get;
        }

        public virtual int Population
        {
            get;set;
        }

        public virtual string SpeciesDescription
        {
            get;
        }

        public virtual string[] Weapons
        {
            get;set;
        }

        public virtual int NumberOfLegs
        {
            get;
        }

        public virtual int NumberOfEyes
        {
            get;
        }

        public virtual string TypeOfComics
        {
            get;
        }

        public bool IsSpeciesDead
        {
            get { return Population <= 0; }
        }

        public Species(int population)
        {
            Population = population;
        }

        public static Species GetSpecies(string speciesName, int population)
        {
            Species species;
            switch (speciesName)
            {
                case "Delek":
                    species = new Dalek(population);
                    break;
                case "Predador":
                    species = new Predador(population);
                    break;
                default:
                    species = new Sleestak(population);
                    break;
            }

            return species;
        }
    }
}
