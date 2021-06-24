using System;
namespace SE307_Project
{
    public class SuperMissilesStation:MissilesStation
    {
        public override void fireTheMissiles(AirCraft airCraft)
        {
            superMissiles.MissilesStaus = "The Missiles are fired up towards the AirCraft";
            Console.WriteLine(superMissiles.MissilesStaus);
            if (superMissiles.Speed <= airCraft.Speed)
            {
                superMissiles.MissilesStaus =
                    "The Aircrafts speed is bigger than our Missiles speed so it will not hit the aircraft";
                Console.WriteLine(superMissiles.MissilesStaus);
                superMissiles.MissilesStaus = "Our Missile is going to land on clear area";
                Console.WriteLine(superMissiles);
                superMissiles.MissilesStaus = "Our Missile is landed is safely";
                superMissiles.IsHit = false;
            }
            if (superMissiles.checkTheHittingPercent() == false)
            {
                superMissiles.IsHit = false;
                return;
            }

            superMissiles.MissilesStaus =
                "The Missile hit the AirCraft successfully and they are dropping in safe area";
            Console.WriteLine(superMissiles.MissilesStaus);
            superMissiles.IsHit = true;
        }

        private SuperMissiles superMissiles = new SuperMissiles();

        public SuperMissiles SuperMissiles
        {
            get => superMissiles;
            set => superMissiles = value;
        }

        public SuperMissilesStation(int location, string name,SuperMissiles superMissiles) : base(location, name)
        {
            this.superMissiles = superMissiles;
        }

        public SuperMissilesStation()
        {
        }
    }
}