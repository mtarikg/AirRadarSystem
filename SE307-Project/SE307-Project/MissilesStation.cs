using System.Collections.Generic;

namespace SE307_Project
{
    public abstract class MissilesStation
    {
        private int location; //location is the x axis 
        private string name;
        private List<Missile> missiles;

        public MissilesStation()
        {
        }

        public MissilesStation(int location, string name, List<Missile> missiles)
        {
            this.location = location;
            this.name = name;
            this.missiles = missiles;
        }

        public int Location
        {
            get => location;
            set => location = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public List<Missile> Missiles { get => missiles; set => missiles = value; }

        // this is an abstract method to let its child classes implement in their own ways.
        // missile is passed here as a parameter instead of using an instance created in the child classes.
        public abstract bool FireTheMissiles(Missile missile, AirCraft airCraft);
    }
}