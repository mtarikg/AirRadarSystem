namespace SE307_Project
{
    public abstract class AirCraft // declared abstract to prevent creating instances from this class
    {
        private int id;
        private string type;
        private Country departure;
        private Country destination;
        private double speed;
        private double xValue;
        private double yValue;

        protected AirCraft(int id, string type, Country departure, Country destination, double speed, double X, double Y)
        {
            this.id = id;
            this.type = type;
            this.departure = departure;
            this.destination = destination;
            this.speed = speed;
            this.xValue = X;
            this.yValue = Y;
        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public Country Departure { get => departure; set => departure = value; }
        public Country Destination { get => destination; set => destination = value; }
        public double Speed { get => speed; set => speed = value; }

        public double XValue
        {
            get => xValue;
            set => xValue = value;
        }

        public double YValue
        {
            get => yValue;
            set => yValue = value;
        }
        
    }
}