namespace SE307_Project
{
    public abstract class AirCraft // declared abstract to prevent creating instances from this class since it's the base to its child ones.
    {
        private int id; // in case two aircrafts have the same type, we need to keep track of which one is which by assigning them an id.
        private string type;
        private string departure;
        private string destination;
        private double speed;
        private double xValue; // x coordinate of the aircraft
        private double yValue; // y coordinate of the aircraft

        public AirCraft(int id = default, string type = null, string departure = null, string destination = null, double speed = default, double xValue = default, double yValue = default)
        {
            this.id = id;
            this.type = type;
            this.departure = departure;
            this.destination = destination;
            this.speed = speed;
            this.xValue = xValue;
            this.yValue = yValue;
        }

        // Setters and getters 
        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string Departure { get => departure; set => departure = value; }
        public string Destination { get => destination; set => destination = value; }
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