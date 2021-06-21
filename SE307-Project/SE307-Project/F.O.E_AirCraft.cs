namespace SE307_Project
{
    public class F_O_E_AirCraft:AirCraft
    {
        public F_O_E_AirCraft(string type, string countryName, double speed, int positionX, int positionY, Country destination) : base(type, countryName, speed, positionX, positionY, destination)
        {
        }

        public F_O_E_AirCraft()
        {
        }

        public  void move()
        {
            throw new System.NotImplementedException();
        }
    }
}