using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE307_Project
{
    class CountryManager : IDataService<Country>, IOperationService<Country, Country>
    {
        private AircraftManager aircraftManager;
        private MissileManager missileManager;

        public CountryManager(AircraftManager aircraftManager, MissileManager missileManager)
        {
            this.aircraftManager = aircraftManager;
            this.missileManager = missileManager;
        }

        public void Add(Country allyCountry, Country country)
        {
            country.AlliesCountries.Add(allyCountry);
            Console.WriteLine("The following country, " + allyCountry.CountryName + ", has been added to the country as an ally: " + country.CountryName + ".");
            Console.WriteLine();
        }

        public void Delete(Country enemyCountry, Country country)
        {
            bool isCountryFound = false;
            foreach (var eachEnemyCountry in country.EnemyCountries)
            {
                if (enemyCountry.CountryName.Equals(eachEnemyCountry.CountryName) && enemyCountry.Id == eachEnemyCountry.Id)
                {
                    isCountryFound = true;
                    break;
                }
            }

            if (isCountryFound)
            {
                country.EnemyCountries.Remove(enemyCountry);
                Console.WriteLine("The following country, " + enemyCountry.CountryName + ", has been deleted from the enemy list of the country: " + country.CountryName + ".");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Turkey has no such enemy country.");
            }
        }

        public string ShowData(Country country)
        {
            Console.WriteLine("Here is all information of the country: ");
            Console.WriteLine("Country name: " + country.CountryName);
            Console.WriteLine("Country population: " + country.Population);
            Console.WriteLine("Country area: " + country.Area);
            if (country.AirStation != null)
            {
                Console.WriteLine("Its air station: " + country.AirStation.Name);
            }
            else
            {
                Console.WriteLine(country.CountryName + " has no air station at the moment.");
            }


            if (country.Aircrafts != null && country.Aircrafts.Count != 0)
            {
                Console.WriteLine("All aircrafts that " + country.CountryName + " has: ");
                foreach (var aircraft in country.Aircrafts)
                {
                    aircraftManager.ShowData(aircraft);
                }
            }
            else
            {
                Console.WriteLine(country.CountryName + " has no aircrafts at the moment.");
            }

            if (country.Missiles != null && country.Missiles.Count != 0)
            {
                Console.WriteLine("All missiles that " + country.CountryName + " has: ");
                foreach (var missile in country.Missiles)
                {
                    missileManager.ShowData(missile);
                }
            }
            else
            {
                Console.WriteLine(country.CountryName + " has no missiles at the moment.");
            }

            if (country.AlliesCountries != null && country.AlliesCountries.Count != 0)
            {
                Console.WriteLine("All countries that are an ally for " + country.CountryName + " : ");
                foreach (var allyCountry in country.AlliesCountries)
                {
                    ShowData(allyCountry);
                }
            }
            else
            {
                Console.WriteLine(country.CountryName + " has no ally country at the moment.");
            }

            if (country.EnemyCountries != null && country.EnemyCountries.Count != 0)
            {
                Console.WriteLine("All countries that are an enemy for " + country.CountryName + " : ");
                foreach (var enemyCountry in country.EnemyCountries)
                {
                    ShowData(enemyCountry);
                }
            }
            else
            {
                Console.WriteLine(country.CountryName + " has no enemy country at the moment.");
            }
            Console.WriteLine();
            return null;
        }
    }
}
