using System;

namespace SE307_Project
{
    public class CalculationManager:ICalculationService
    {
        private double AirCraftMovementDistance;
        private double clashPointX;
        private double clashPointY;
        private double MissileDistance;
        private double time;
        private AirCraft airCraft;
        private Missile missile;
        private MissilesStation missilesStation;

        public MissilesStation MissilesStation
        {
            get => missilesStation;
            set => missilesStation = value;
        }

        public AirCraft AirCraftT
        {
            get => airCraft;
            set => airCraft = value;
        }

        public Missile MissileT
        {
            get => missile;
            set => missile = value;
        }
        

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
        public void CalcDistance()
        {
            MissileDistance = airCraft.YValue / Math.Cos(45);
            clashPointY = airCraft.YValue;
            AirCraftMovementDistance = MissileDistance * clashPointY;
            clashPointX = missilesStation.Location - AirCraftMovementDistance;
            
        }

        public void CalcTime()
        {
            time = AirCraftMovementDistance / airCraft.Speed;
        }

        public void DisplayTheClash()
        {
            Console.WriteLine("Clash Info: ");
            Console.WriteLine("The Clash Happened Between The AirCraft and The Missile in ");
            Console.WriteLine("("+clashPointX+" , "+ClashPointY+")" +" Point ");
            Console.WriteLine("The AirCraft has moved  "+AirCraftMovementDistance+" KM In The Country Borders");
            Console.WriteLine("The Missile Moved "+MissileDistance+" KM in the Country Borders");
            Console.WriteLine("The Clash Happened After "+time+" hours after the aircraft entered the borders ");
        }

        public void methodsContainer()
        {
            CalcDistance();
            CalcTime();
            DisplayTheClash();
        }
    }
}