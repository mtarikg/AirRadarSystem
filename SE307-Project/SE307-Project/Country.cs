using System.Collections.Generic;

namespace SE307_Project
{
    public class Country
    {
        private int id;
        private string countryName;
        private double population;
        private double area;
        private AirStation airStation; // a country must have an air station.
        private List<AirCraft> aircrafts; // a country can have multiple aircrafts.
        private List<Missile> missiles; // a country can have multiple missiles.

        public Country(int id, string countryName, double population, double area, AirStation airStation, List<AirCraft> aircrafts, List<Missile> missiles)
        {
            this.id = id;
            this.countryName = countryName;
            this.population = population;
            this.area = area;
            this.airStation = airStation;
            this.aircrafts = aircrafts;
            this.missiles = missiles;
        }

        public int Id { get => id; set => id = value; }
        public string CountryName { get => countryName; set => countryName = value; }
        public double Population { get => population; set => population = value; }
        public double Area { get => area; set => area = value; }
        public AirStation AirStation { get => airStation; set => airStation = value; }
        public List<AirCraft> Aircrafts { get => aircrafts; set => aircrafts = value; }
        public List<Missile> Missiles { get => missiles; set => missiles = value; }
    }
}