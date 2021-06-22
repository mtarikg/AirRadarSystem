namespace SE307_Project
{
    public class LightMissiles:Missile
    {
        private string type;
        private int powerRank; // from 1-10 10 is the most powerful for the light Missiles
        

        public int PowerRank
        {
            get => powerRank;
            set => powerRank = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public LightMissiles(int id, double speed, string type, int powerRank) : base(id, speed)
        {
            this.type = type;
            this.powerRank = powerRank;
        }
         public override bool checkTheHittingPercent()
           {
                 throw new System.NotImplementedException();  
             }

       

        public LightMissiles()
        {
        }
    }
}