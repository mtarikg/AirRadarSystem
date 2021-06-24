using System;
using System.Collections.Generic;

namespace SE307_Project
{
    public class LightMissilesStation:MissilesStation
    {
        public LightMissilesStation(int location, string name, List<Missile> missiles) : base(location, name, missiles)
        {
        }

        public override void fireTheMissiles(Missile lightMissile, AirCraft airCraft)
        {
            lightMissile.MissilesStaus = "The Missiles are fired up towards the AirCraft";
            Console.WriteLine(lightMissile.MissilesStaus);
            if (lightMissile.Speed <= airCraft.Speed)
            {
                lightMissile.MissilesStaus =
                    "The Aircrafts speed is bigger than our Missiles speed so it will not hit the aircraft";
                Console.WriteLine(lightMissile.MissilesStaus);
                lightMissile.MissilesStaus = "Our Missile is going to land on clear area";
                Console.WriteLine(lightMissile);
                lightMissile.MissilesStaus = "Our Missile is landed is safely";
                lightMissile.IsHit = false;
                return;
            }

            if (lightMissile.checkTheHittingPercent() == false)
            {
                lightMissile.IsHit = false;
                return;
            }

            lightMissile.MissilesStaus =
                "The Missile hit the AirCraft successfully and they are dropping in safe area";
            Console.WriteLine(lightMissile.MissilesStaus);
            lightMissile.IsHit = true;
            

        }
    }
}