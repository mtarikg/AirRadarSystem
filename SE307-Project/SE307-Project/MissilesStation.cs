using System.Collections.Generic;

namespace SE307_Project
{
    public abstract class MissilesStation
    {
        private int location;//location is the x axis 
        private string name;
        
        // the approach was to contain any type of missiles without declaring it separately
        private List<Missile> missiles;

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

        // missile is passed here as a parameter instead of using an instance created in the child classes.
        public abstract void fireTheMissiles(Missile missile, AirCraft airCraft);  

        protected MissilesStation(int location, string name, List<Missile> missiles)
        {
            this.location = location;
            this.name = name;
            this.missiles = missiles;
        }
    }
}