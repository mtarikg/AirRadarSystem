using System;

namespace SE307_Project
{
    public class Manager:IManager
    {
        private double AirCraftMovementDistance;
        private double clashPointX;
        private double clashPointY;
        private double MissileDistance;
        private double time;

        public double AirCraftMovementDistance1
        {
            get => AirCraftMovementDistance;
            set => AirCraftMovementDistance = value;
        }

        public double ClashPointX
        {
            get => clashPointX;
            set => clashPointX = value;
        }

        public double ClashPointY
        {
            get => clashPointY;
            set => clashPointY = value;
        }

        public double MissileDistance1
        {
            get => MissileDistance;
            set => MissileDistance = value;
        }

        public double Time
        {
            get => time;
            set => time = value;
        }
        public void calcDistance(AirCraft airCraft,Missile missile,MissilesStation missilesStation)
        {
            MissileDistance = airCraft.YValue / Math.Cos(45);
            clashPointY = airCraft.YValue;
            AirCraftMovementDistance = MissileDistance * clashPointY;
            clashPointX = missilesStation.Location - AirCraftMovementDistance;
            
        }

        public void calcTime(AirCraft airCraft)
        {
            time = AirCraftMovementDistance / airCraft.Speed;
        }
    }
}