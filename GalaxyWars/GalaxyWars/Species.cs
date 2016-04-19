﻿using GalaxyWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
    public abstract class Species : ISpecies
    {
        public abstract string Color
        {
            get;
        }

        public abstract int NumberOfArms
        {
            get;
        }

        public abstract int Population
        {
            get;set;
        }

        public abstract string SpeciesDescription
        {
            get;
        }

        public abstract string[] Weapons
        {
            get;set;
        }

        public abstract int NumberOfLegs
        {
            get;
        }

        public abstract int NumberOfEyes
        {
            get;
        }

        public abstract string TypeOfComics
        {
            get;
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
                case "Dalek":
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
