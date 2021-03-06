using System;
using System.Collections.Generic;

namespace SE307_Project
{
    public class SuperMissilesStation : MissilesStation
    {
        private bool isHitStatus;

        public SuperMissilesStation()
        {
        }

        public SuperMissilesStation(int location, string name, List<Missile> missiles) : base(location, name, missiles)
        {
        }

        public bool IsHitStatus
        {
            get => isHitStatus;
            set => isHitStatus = value;
        }

        public override bool FireTheMissiles(Missile superMissile, AirCraft airCraft)
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
                IsHitStatus = false;
                return false;
            }
            if (superMissile.CheckTheHittingPercent() == false)
            {
                superMissile.IsHit = false;
                superMissile.MissilesStaus =
                    "We got unlucky the shot did not hit the air craft due to miss-calculations";
                Console.WriteLine(superMissile.MissilesStaus);
                superMissile.MissilesStaus = "The Missile is going to land on safe area";
                Console.WriteLine(superMissile.MissilesStaus);
                superMissile.MissilesStaus = "Our Missile is landed is safely";
                IsHitStatus = false;
                return false;
            }

            superMissile.MissilesStaus =
                "The Missile hit the AirCraft successfully and they are dropping in safe area";
            Console.WriteLine(superMissile.MissilesStaus);
            superMissile.IsHit = true;
            isHitStatus = true;
            return true;
        }
    }
}