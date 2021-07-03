using System;

namespace SE307_Project
{
    // This is a manager class in which necessary calculations are handled in case of a collision.
    public class CalculationManager : ICalculationService
    {
        private double airCraftMovementDistance;
        private double clashPointX;
        private double clashPointY;
        private double missileDistance;
        private double time;
        private AirCraft airCraft;
        private Missile missile;
        private MissilesStation missilesStation;

        public MissilesStation MissilesStation
        {
            get => missilesStation;
            set => missilesStation = value;
        }

        public AirCraft AirCraft
        {
            get => airCraft;
            set => airCraft = value;
        }

        public Missile Missile
        {
            get => missile;
            set => missile = value;
        }


        public double AirCraftMovementDistance1
        {
            get => airCraftMovementDistance;
            set => airCraftMovementDistance = value;
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
            get => missileDistance;
            set => missileDistance = value;
        }

        public double Time
        {
            get => time;
            set => time = value;
        }
        public void CalcDistance()
        {
            missileDistance = airCraft.YValue / Math.Cos(45);
            clashPointY = airCraft.YValue;
            airCraftMovementDistance = missileDistance * clashPointY;
            clashPointX = missilesStation.Location - airCraftMovementDistance;

        }

        public void CalcTime()
        {
            time = airCraftMovementDistance / airCraft.Speed;
        }

        public void DisplayTheClash()
        {
            Console.WriteLine("Clash Info: ");
            Console.WriteLine("The Clash Happened Between The AirCraft and The Missile in ");
            Console.WriteLine("(" + clashPointX + " , " + clashPointY + ")" + " Point ");
            Console.WriteLine("The AirCraft has moved  " + airCraftMovementDistance + " KM In The Country Borders");
            Console.WriteLine("The Missile Moved " + missileDistance + " KM in the Country Borders");
            Console.WriteLine("The Clash Happened After " + time + " hours after the aircraft entered the borders ");
        }

        public void MethodsContainer()
        {
            CalcDistance();
            CalcTime();
            DisplayTheClash();
        }
    }
}