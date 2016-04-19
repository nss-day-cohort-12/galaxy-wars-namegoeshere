using GalaxyWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
    public class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Start Program...");
            Random random = new Random();//psuedo random-number generator
            Dalek dalek = new Dalek(1000000);
            //dalek.Population = 1000000;
            Sleestak sleestak = new Sleestak(1000000);
            //sleestak.Population = 1000000;
            Predador predador = new Predador(1000000);
            //predador.Population = 1000000;   
            Console.WriteLine("Religion Name for Sleestak: " + sleestak.ReligionName);
            //Species dalek = Species.GetSpecies("Dalek", 1000000);
            //Species sleestak = Species.GetSpecies("Sleestak", 1000000);
            //Species predador = Species.GetSpecies("Predador", 1000000);


            //Battle Logic
            //start of game setting a start year
            bool beginGame = true;
            int year = 3000;
            
            while (beginGame)
            {
               
                var xyz = turnRound(random, year, dalek.Population, sleestak.Population, predador.Population);
                dalek.Population = xyz[0];
                sleestak.Population = xyz[1];
                predador.Population = xyz[2];
                //Console.Write(""); make one for each new population
                ////game over check
                //if dalek and sleestak population = 0, predador win
                //else if sleestak and predador pop = 0, dalek win
                //else if dalek and predador pop = 0, sleestak win
                if (dalek.Population <= 0 && sleestak.Population <= 0)
                {
                    Console.WriteLine("Predadors claim ultimate victory.\n");
                    beginGame = false;
                }
                else if(dalek.Population <= 0 && predador.Population <= 0)
                {
                    Console.WriteLine("SLEESTAK, sleeeezed the entire stack to glory.\n");
                    beginGame = false;
                }
                else if(predador.Population <= 0 && sleestak.Population <= 0)
                {
                    Console.WriteLine("Daleks have exterminated all competitors.\n");
                    beginGame = false;
                }

                year++;
            }
  
        }

        static public List<double> turnRound(Random random, int year, double spaceFaringPopulation, double warriorPopulation, double religionPopulation)
        {
            //science beats religion
            //religion beats warfare
            //warfare beats science
            bool scienceBeatsReligion = true;
            bool religionBeatsWarfare = true;
            bool warfareBeatsScience = true;
            //bool scienceBeatsWarfare = false;
            //bool warfareBeatsReligion = false;
            //bool religionBeatsScience = false;

            if (year % 25 == 0)//a rule gets reversed every 25 years
            {
                int randomYear = random.Next(0, 3);
                Console.WriteLine("A blackhole has changed time and space reversing some factors " + randomYear + "uh, ohhhh!");
                switch (randomYear)
                {
                    case 0:
                        scienceBeatsReligion = false;
                        break;
                    case 1:
                        religionBeatsWarfare = false;
                        break;
                    case 2:
                        warfareBeatsScience = false;
                        break;
                    default:
                        break;
                }
            }

            // number 9 in requirements for base population rules
            // each species loses 20,000
            spaceFaringPopulation -= 20000;
            warriorPopulation -= 20000;
            religionPopulation -= 20000;
            // spacefaring gains 5000
            spaceFaringPopulation += 5000;
            // 10,000 killed by warrior
            religionPopulation -= 10000;
            // 10,000 killed by warrior
            spaceFaringPopulation -= 10000;
            //warrior loses 2500
            warriorPopulation -= 2500;
            //religion gains, warrior loses, 1% of warrior population
            religionPopulation += warriorPopulation * 0.01;
            warriorPopulation *= 0.99;
            //religion gains, science loses, 1% of science population
            religionPopulation += spaceFaringPopulation * 0.01;
            spaceFaringPopulation *= 0.99;

            // weighted battles 
            //SpaceFaring fights Religion
            if (scienceBeatsReligion)
            {
                if (spaceFaringPopulation > 0)
                {
                    religionPopulation *= 0.98;//weight battle bonus
                }
            }
            else
            {
                if (religionPopulation > 0)
                {
                    spaceFaringPopulation *= 0.98;
                }
            }
            //SpaceFaring fights Warrior
            if (warfareBeatsScience)
            {
                if (warriorPopulation > 0)
                {
                    spaceFaringPopulation *= 0.98;
                }
            }
            else
            {
                if (spaceFaringPopulation > 0)
                {
                    warriorPopulation *= 0.98;
                }
            }
            //Warrior fights Religion
            if (religionBeatsWarfare)
            {
                if (religionPopulation > 0)
                {
                    warriorPopulation *= 0.98;
                }
            }
            else
            {
                if (warriorPopulation > 0)
                {
                    religionPopulation *= 0.98;
                }
            }

            if (spaceFaringPopulation <= 0) spaceFaringPopulation = 0;
            if (warriorPopulation <= 0) warriorPopulation = 0;
            if (religionPopulation <= 0) religionPopulation = 0;

            List<double> returnValues = new List<double>();
            returnValues.Add(Math.Floor(spaceFaringPopulation));
            returnValues.Add(Math.Floor(warriorPopulation));
            returnValues.Add(Math.Floor(religionPopulation));
            return returnValues;
        }


    }
}
//Console.WriteLine("Program finished.  Press any key to exit.");
           // Console.ReadKey();
            //readkey and for loop/while to make the battle



//  


