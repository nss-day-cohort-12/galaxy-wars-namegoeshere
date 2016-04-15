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
            Daleks daleks = new Daleks();
            daleks.population = 1000000;

            Sleestak sleestak = new Sleestak();
            sleestak.population = 1000000;

            Predador predador = new Predador();
            predador.population = 1000000;

            //Battle Logic
        }
    }
}
