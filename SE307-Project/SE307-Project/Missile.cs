namespace SE307_Project
{
    // declared abstract to prevent creating instances from this class, there might be missile types being added later.
    public abstract class Missile
    {
        private int id;
        private double speed;
        private string missilesStaus;
        private bool isHit;// to check if the missile hit the the aircraft

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

        protected Missile(int id, double speed)
        {
            this.id = id;
            this.speed = speed;
        }

        protected Missile()
        {
        }

        public int Id { get => id; set => id = value; }

        public double Speed
        {
            get => speed;
            set => speed = value;
        }

        public abstract bool checkTheHittingPercent();// gives a random value depending on a functionality percentage

    }
}