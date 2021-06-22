namespace SE307_Project
{
    public abstract class AirCraft // declared abstract to prevent creating instances from this class
    {
        private int id;
        private string type;
        private Country departure;
        private Country destination;
        private double speed;
        private double latitude;
        private double longitude;

        protected AirCraft(int id, string type, Country departure, Country destination, double speed, double latitude, double longitude)
        {
            this.id = id;
            this.type = type;
            this.departure = departure;
            this.destination = destination;
            this.speed = speed;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public Country Departure { get => departure; set => departure = value; }
        public Country Destination { get => destination; set => destination = value; }
        public double Speed { get => speed; set => speed = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
    }
}