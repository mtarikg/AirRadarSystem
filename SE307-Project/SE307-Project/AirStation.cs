namespace SE307_Project
{
    public class AirStation
    {
        private string name;
        private Radar radar; // an air station must have a radar to observe the airline.

        public AirStation(string name, Radar radar)
        {
            this.name = name;
            this.radar = radar;
        }

        public string Name { get => name; set => name = value; }
        public Radar Radar { get => radar; set => radar = value; }
    }
}