namespace SE307_Project
{
    public  class  AirCraft
    {
        private string type,countryName;
        private double speed;
        private int positionX, positionY;
        private Country destination = new Country();

        public string Type
        {
            get => type;
            set => type = value;
        }

        public string CountryName
        {
            get => countryName;
            set => countryName = value;
        }

        public double Speed
        {
            get => speed;
            set => speed = value;
        }

        public int PositionX
        {
            get => positionX;
            set => positionX = value;
        }

        public int PositionY
        {
            get => positionY;
            set => positionY = value;
        }

        public Country Destination
        {
            get => destination;
            set => destination = value;
        }

        public AirCraft(string type, string countryName, double speed, int positionX, int positionY,Country destination)
        {
            this.type = type;
            this.countryName = countryName;
            this.speed = speed;
            this.positionX = positionX;
            this.positionY = positionY;
            this.destination = destination;

        }

        public AirCraft()
        {
        }

        public void move()
        {
        }



    }
}