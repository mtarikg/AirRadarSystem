namespace SE307_Project
{
    public class Unkown_AirCraft:AirCraft
    {
        public  void move()
        {
            throw new System.NotImplementedException();
        }

        private double speed;
        private Country destination = new Country();
        private string type;
        

       

        public Unkown_AirCraft(string type,double speed)
        {
            Speed = speed;
            destination = null;
            Type = type;
            CountryName = null;
            

        }
    }
}