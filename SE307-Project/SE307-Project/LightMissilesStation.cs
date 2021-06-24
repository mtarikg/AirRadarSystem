using System;

namespace SE307_Project
{
    public class LightMissilesStation:MissilesStation
    {
        public override void fireTheMissiles(AirCraft airCraft)
        {
            lightMissiles.MissilesStaus = "The Missiles are fired up towards the AirCraft";
            Console.WriteLine(lightMissiles.MissilesStaus);
            if (lightMissiles.Speed <= airCraft.Speed)
            {
                lightMissiles.MissilesStaus =
                    "The Aircrafts speed is bigger than our Missiles speed so it will not hit the aircraft";
                Console.WriteLine(lightMissiles.MissilesStaus);
                lightMissiles.MissilesStaus = "Our Missile is going to land on clear area";
                Console.WriteLine(lightMissiles);
                lightMissiles.MissilesStaus = "Our Missile is landed is safely";
                lightMissiles.IsHit = false;
                return;
            }

            if (lightMissiles.checkTheHittingPercent() == false)
            {
                lightMissiles.IsHit = false;
                return;
            }

            lightMissiles.MissilesStaus =
                "The Missile hit the AirCraft successfully and they are dropping in safe area";
            Console.WriteLine(lightMissiles.MissilesStaus);
            lightMissiles.IsHit = true;
            

        }
        

        private LightMissiles lightMissiles = new LightMissiles();

        public LightMissilesStation(int location, string name,LightMissiles lightMissiles) : base(location, name)
        {
            this.lightMissiles = lightMissiles;
        }

        public LightMissilesStation()
        {
        }

        public LightMissiles LightMissiles
        {
            get => lightMissiles;
            set => lightMissiles = value;
        }

       
    }
}