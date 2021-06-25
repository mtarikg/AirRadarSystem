using System;
using System.Security.Cryptography;

namespace SE307_Project
{
    public class LightMissiles : Missile
    {
        public LightMissiles(int id, double speed, string type, int powerRank) : base(id, type, speed, powerRank)
        {
            
        }
        public override bool checkTheHittingPercent()
        {
            Random rand = new Random();
            int randomPercent = rand.Next(1, 99);
            if (randomPercent > 50)
            {
                return false;
            }

            return true;

        }
    }
}