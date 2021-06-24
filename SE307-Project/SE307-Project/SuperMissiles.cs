using System;

namespace SE307_Project
{
    public class SuperMissiles:Missile
    {
        private int powerRank; //from 1-10 10 is the best

        public int PowerRank
        {
            get => powerRank;
            set => powerRank = value;
        }

        public SuperMissiles(int id, double speed, string type, int powerRank) : base(id, type, speed)
        {
            this.powerRank = powerRank;
        }

         public override bool checkTheHittingPercent()
        {
            Random rand = new Random();
            int randomPercent = rand.Next(1,99);
            if (randomPercent > 80)
            {
                return false;
            }

            return true;
        } 
         
    }
    }
