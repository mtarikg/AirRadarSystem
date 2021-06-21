namespace SE307_Project
{
    public class AirCraftCountry:Country
    {
        private AirCraft AirCraft = new AirCraft();
        public AirCraftCountry(string countryName, double population, double areaInKm2,AirCraft airCraft) : base(countryName, population, areaInKm2)
        {
            this.AirCraft = airCraft;
        }

        public AirCraftCountry()
        {
        }
    }
}