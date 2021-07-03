namespace SE307_Project
{
    // declared abstract to prevent creating instances from this class; it's the base for its child classes.
    public abstract class Missile
    {
        private int id; // in case two missiles have the same type, we need to keep track of which one is which by assigning them an id.
        private string type;
        private double speed;
        private string missilesStaus;
        private bool isHit; // to check if the missile hit the the aircraft
        private int powerRank;

        public bool IsHit
        {
            get => isHit;
            set => isHit = value;
        }


        public string MissilesStaus
        {
            get => missilesStaus;
            set => missilesStaus = value;
        }

        public Missile(int id, string type, double speed, int powerRank)
        {
            this.type = type;
            this.id = id;
            this.speed = speed;
            this.powerRank = powerRank;
        }

        public int Id { get => id; set => id = value; }

        public double Speed
        {
            get => speed;
            set => speed = value;
        }
        public string Type { get => type; set => type = value; }
        public int PowerRank { get => powerRank; set => powerRank = value; }

        // this is an abstract method to let its child classes implement in their own ways.
        public abstract bool CheckTheHittingPercent(); // gives a random value depending on a functionality percentage
    }
}