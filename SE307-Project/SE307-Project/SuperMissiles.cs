using System;

namespace SE307_Project
{
    public class SuperMissiles : Missile
    {
        public SuperMissiles(int id, double speed, string type, int powerRank) : base(id, type, speed, powerRank)
        {
            
        }

        public override bool checkTheHittingPercent()
        {
            Random rand = new Random();
            int randomPercent = rand.Next(1, 99);
            if (randomPercent > 80)
            {
                return false;
            }

            return true;
        }

    }
}
