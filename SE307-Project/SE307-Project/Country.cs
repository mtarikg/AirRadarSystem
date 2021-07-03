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
        // a country can have an air station, multiple aircrafts, multiple missiles, multiple allies and multiple enemies.
        private AirStation airStation;
        private List<AirCraft> aircrafts;
        private List<Missile> missiles;
        private List<Country> alliesCountries;
        private List<Country> enemyCountries;
        // a country can have two missiles stations; one is for light missiles and the other for super missiles.
        private LightMissilesStation lightMissilesStation;
        private SuperMissilesStation superMissilesStation;

        // a country can exist with no information about aircrafts, missiles, allies or enemies.
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