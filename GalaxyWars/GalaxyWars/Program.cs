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
            Battle speciesBattle = new Battle(dalek, sleestak, predador);

            while(true)
            {
                speciesBattle.FightBattle();
                Console.WriteLine("Population of Dalek: " + dalek.Population);
                Console.WriteLine("Population of Predador " + predador.Population);
                Console.WriteLine("Population of Sleestak " + sleestak.Population);
                if (speciesBattle.FirstDeadSpecies != null)
                {
                    Console.WriteLine("We have a loser!");
                    Console.WriteLine("The species " + speciesBattle.FirstDeadSpecies.Name + " has been destroyed!");
                    break;
                }
            }

            //Species dalek = Species.GetSpecies("Dalek", 1000000);
            //Species sleestak = Species.GetSpecies("Sleestak", 1000000);
            //Species predador = Species.GetSpecies("Predador", 1000000);


            //Battle Logic
            //start of game setting a start year
            //while (gamestart)
            //var thething = round(populations,????)
 //game over check
            //if dalek and sleestak population = 0, predador win
            //else if sleestak and predador pop = 0, dalek win
            //else if dalek and predador pop = 0, sleestak win
 //need rule to reverse the rules every 25 years
            //science beats religion = true;
            //religion beats warfare = true;
            //warfare beats science = true;
                //a rule gets reversed every 25 years
                //randomize?
 //  number 9 in requirements for base population rules
            //each species loses 20,000
                //sciencePopulation -= 20000;
                //warriorPopulation -= 20000;
                //religionPopulation -= 20000;
            //science gains 5000
                //sciencePopulation += 5000;
            //additional 10,000 killed by warrior
                //religionPopulation -= 10000;
            //additional 10,000 killed by warrior
                //sciencePopulation -= 10000;
            //warrior loses 2500
                //warriorPopulation -= 2500;
            //religion gains, warrior loses, 1% of warrior population
                //religionPopulation += warriorPopulation * 0.01;
                //warrior population *= 0.99;???
            //religion gains, science loses, 1% of science population
                //religionPopulation += sciencePopulation * 0.01;
                //science population *= 0.99;???
  // weight battles 
    //Science beats Religion
    //Religion beats Warrior
    //Warrior beats Science
            //Science fights religion
                //if (scienceBeatsReligion)...
                    // minus 2% from religionPopulation
            
            //science fights warrior
                //if (warriorBeatsScience)
                    //minus 2% from sciencePopulation
                    
            //warrior fights religion
                //if (religionBeatsWarrior)
                    //minus 2% from warriorPopulation
                    
               
                  
        

            Console.WriteLine("Program finished.  Press any key to exit.");
            Console.ReadKey();
            //readkey and for loop/while to make the battle
        }


    }
}
