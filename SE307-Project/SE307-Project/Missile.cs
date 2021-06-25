namespace SE307_Project
{
    // declared abstract to prevent creating instances from this class.
    public abstract class Missile
    {
        private int id;
        private string type;
        private double speed;
        private string missilesStaus;
        private bool isHit;// to check if the missile hit the the aircraft
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

        protected Missile(int id, string type, double speed, int powerRank)
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

        public abstract bool checkTheHittingPercent();// gives a random value depending on a functionality percentage

    }
}