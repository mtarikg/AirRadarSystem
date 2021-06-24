namespace SE307_Project
{
    public abstract class MissilesStation
    {
        private int location;//location is the x axis 
        private string name;

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

        public abstract void fireTheMissiles(AirCraft airCraft);

        protected MissilesStation(int location, string name)
        {
            this.location = location;
            this.name = name;
        }

        protected MissilesStation()
        {
        }
    }
}