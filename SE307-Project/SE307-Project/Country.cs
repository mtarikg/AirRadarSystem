namespace SE307_Project
{
    public class Country
    {
        private string countryName;
        private double population, areaInKM2;

        public string CountryName
        {
            get => countryName;
            set => countryName = value;
        }

        public double Population
        {
            get => population;
            set => population = value;
        }

        public double AreaInKm2
        {
            get => areaInKM2;
            set => areaInKM2 = value;
        }

        public Country(string countryName, double population, double areaInKm2)
        {
            this.countryName = countryName;
            this.population = population;
            areaInKM2 = areaInKm2;
        }

        public Country()
        {
        }
    }
}