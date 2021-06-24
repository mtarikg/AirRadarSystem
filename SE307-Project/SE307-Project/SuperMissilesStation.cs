using System;
using System.Collections.Generic;

namespace SE307_Project
{
    public class SuperMissilesStation:MissilesStation
    {
        public SuperMissilesStation(int location, string name, List<Missile> missiles) : base(location, name, missiles)
        {
        }

        private bool isHitStatus;
        

        public bool IsHitStatus
        {
            get => isHitStatus;
            set => isHitStatus = value;
        }

        public override void fireTheMissiles(Missile superMissile, AirCraft airCraft)
        {
            superMissile.MissilesStaus = "The Missiles are fired up towards the AirCraft";
            Console.WriteLine(superMissile.MissilesStaus);
            if (superMissile.Speed <= airCraft.Speed)
            {
                superMissile.MissilesStaus =
                    "The Aircrafts speed is bigger than our Missiles speed so it will not hit the aircraft";
                Console.WriteLine(superMissile.MissilesStaus);
                superMissile.MissilesStaus = "Our Missile is going to land on clear area";
                superMissile.MissilesStaus = "Our Missile is landed is safely";
                superMissile.IsHit = false;
                isHitStatus = false;
            }
            if (superMissile.checkTheHittingPercent() == false)
            {
                superMissile.IsHit = false;
                superMissile.MissilesStaus =
                    "We got unlucky the shot did not hit the air craft due to miss-calculations";
                Console.WriteLine(superMissile.MissilesStaus);
                superMissile.MissilesStaus = "The Missile is going to land on safe area";
                Console.WriteLine(superMissile.MissilesStaus);
                Console.WriteLine(superMissile);
                superMissile.MissilesStaus = "Our Missile is landed is safely";
                isHitStatus = false;
                return;
            }

            superMissile.MissilesStaus =
                "The Missile hit the AirCraft successfully and they are dropping in safe area";
            Console.WriteLine(superMissile.MissilesStaus);
            superMissile.IsHit = true;
            isHitStatus = true;
        }

        public SuperMissilesStation()
        {
        }
    }
}