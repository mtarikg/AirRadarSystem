namespace SE307_Project
{
    public class Friend_AirCraft:AirCraft
    {
        public  void move()
        {
            throw new System.NotImplementedException();
        }

        private Country enemyCountry = new Country();

      

        public Friend_AirCraft(string type, string countryName, double speed, int positionX, int positionY, Country destination,Country enemyCountry) : base(type, countryName, speed, positionX, positionY, destination)
        {
            this.enemyCountry = enemyCountry;
        }

        public Friend_AirCraft()
        {
        }
    }
}