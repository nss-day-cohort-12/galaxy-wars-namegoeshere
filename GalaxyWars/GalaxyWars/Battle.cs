using GalaxyWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWars
{
    public class Battle
    {
        private Dalek _dalek;
        private Sleestak _sleestak;
        private Predador _predador;
        private bool _scienceBeatsReligion = true;
        private bool _religionBeatsWarfare = true;
        private bool _warfareBeatsScience = true;
        private const int _anomoloyOccurrence = 25;
        private const int _battlePopulationLossBase = 20000;
        private Random _rnd = new Random();
        int _year = 1;

        public Species ReligiousSpecies
        {
            get
            {
                if (_dalek is IReligious)
                    return _dalek;
                else if (_sleestak is IReligious)
                    return _sleestak;
                else
                    return _predador;
            }
        }

        public Species SpacefaringSpecies
        {
            get
            {
                if (_dalek is ISpacefaring)
                    return _dalek;
                else if (_sleestak is ISpacefaring)
                    return _sleestak;
                else
                    return _predador;
            }
        }

        public Species WarriorSpecies
        {
            get
            {
                if (_dalek is IWarrior)
                    return _dalek;
                else if (_sleestak is IWarrior)
                    return _sleestak;
                else
                    return _predador;
            }
        }

        public Species FirstDeadSpecies
        { get; set; }

        public Battle (Dalek dalek, Sleestak sleestak, Predador predador)
        {
            _dalek = dalek;
            _sleestak = sleestak;
            _predador = predador;
        }

        private void CheckYear()
        {
            //int%int is dividing int with another int and the result is the remainder
            //so 25%25 is 0, 50%25 is 0, 75%25 is 0
            if (_year%_anomoloyOccurrence == 0)
            {
                _scienceBeatsReligion = !_scienceBeatsReligion;
                _religionBeatsWarfare = !_religionBeatsWarfare;
                _warfareBeatsScience = !_warfareBeatsScience;
            }
        }

        public void FightBattle()
        {
            CheckYear();

            int firstBattle = _rnd.Next(1,3);

            if (firstBattle == 1)
            {
                ScienceVsReligion();
                ReligionVsWarfare();
                WarfareVsScience();
            }
            else if (firstBattle == 2)
            {
                ReligionVsWarfare();
                WarfareVsScience();
                ScienceVsReligion();
            }
            else
            {
                WarfareVsScience();
                ScienceVsReligion();
                ReligionVsWarfare();
            }

            SpacefaringSpecies.Population += 5000;

            _year++;
        }

        private void CheckSpeciesDeath()
        {
            if (SpacefaringSpecies.IsSpeciesDead)
                FirstDeadSpecies = SpacefaringSpecies;
            else if (ReligiousSpecies.IsSpeciesDead)
                FirstDeadSpecies = ReligiousSpecies;
            else if (WarriorSpecies.IsSpeciesDead)
                FirstDeadSpecies = WarriorSpecies;
        }

        private void ScienceVsReligion()
        {
            SpacefaringSpecies.Population -= _battlePopulationLossBase;
            ReligiousSpecies.Population -= _battlePopulationLossBase;

            CheckSpeciesDeath();

            if (_scienceBeatsReligion)
            {
                ReligiousSpecies.Population -= (int)(ReligiousSpecies.Population * .02);
            }
            else
            {
                SpacefaringSpecies.Population -= (int)(SpacefaringSpecies.Population * .02);
            }

            CheckSpeciesDeath();

            int convertedPopulation = (int)(SpacefaringSpecies.Population * .01);
            ReligiousSpecies.Population += convertedPopulation;
            SpacefaringSpecies.Population -= convertedPopulation;

            CheckSpeciesDeath();
        }

        private void ReligionVsWarfare()
        {
            //NEED TO FINISH THIS LOGIC
        }

        private void WarfareVsScience()
        {
            //NEED TO FINISH THIS LOGIC
        }
    }
}
