using GalaxyWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Program...");
            Dalek dalek = new Dalek(1000000);

            Sleestak sleestak = new Sleestak(1000000);

            Predador predador = new Predador(1000000);

            Console.WriteLine("Religion Name for Sleestak: " + sleestak.ReligionName);
            //Species dalek = Species.GetSpecies("Dalek", 1000000);
            //Species sleestak = Species.GetSpecies("Sleestak", 1000000);
            //Species predador = Species.GetSpecies("Predador", 1000000);


            //Battle Logic


            Console.WriteLine("Program finished.  Press any key to exit.");
            Console.ReadKey();
            //readkey and for loop/while to make the battle
        }


    }
}
