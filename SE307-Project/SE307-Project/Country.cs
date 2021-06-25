using System;
using System.Collections.Generic;

namespace SE307_Project
{
    public class Country
    {
        private int id;
        private string countryName;
        private string population;
        private string area;
        private AirStation airStation; // a country must have an air station.
        private List<AirCraft> aircrafts; // a country can have multiple aircrafts.
        private List<Missile> missiles; // a country can have multiple missiles.
        private List<Country> alliesCountries; // a country can have multiple allies.
        private List<Country> enemyCountries;  // a country can have multiple enemies.
        private LightMissilesStation lightMissilesStation;
        private SuperMissilesStation superMissilesStation;

        public Country(int id, string countryName, string population, string area)
        {
            this.id = id;
            this.countryName = countryName;
            this.population = population;
            this.area = area;
        }

        public Country(int id, string countryName, string population, string area, AirStation airStation, List<AirCraft> aircrafts, List<Missile> missiles, List<Country> alliesCountries, List<Country> enemyCountries, LightMissilesStation lightMissilesStation, SuperMissilesStation superMissilesStation)
        {
            this.id = id;
            this.countryName = countryName;
            this.population = population;
            this.area = area;
            this.airStation = airStation;
            this.aircrafts = aircrafts;
            this.missiles = missiles;
            this.alliesCountries = alliesCountries;
            this.enemyCountries = enemyCountries;
            this.lightMissilesStation = lightMissilesStation;
            this.superMissilesStation = superMissilesStation;
        }

        public int Id { get => id; set => id = value; }
        public string CountryName { get => countryName; set => countryName = value; }
        public string Population { get => population; set => population = value; }
        public string Area { get => area; set => area = value; }
        public AirStation AirStation { get => airStation; set => airStation = value; }
        public List<AirCraft> Aircrafts { get => aircrafts; set => aircrafts = value; }
        public List<Missile> Missiles { get => missiles; set => missiles = value; }

        public List<Country> AlliesCountries
        {
            get => alliesCountries;
            set => alliesCountries = value;
        }

        public List<Country> EnemyCountries
        {
            get => enemyCountries;
            set => enemyCountries = value;
        }

        public LightMissilesStation LightMissilesStation
        {
            get => lightMissilesStation;
            set => lightMissilesStation = value;
        }

        public SuperMissilesStation SuperMissilesStation
        {
            get => superMissilesStation;
            set => superMissilesStation = value;
        }
    }
}