namespace SE307_Project
{
    public class AirStation
    {
        private string name;
        private Radar radar;
        private Alert alert;// an air station must have a radar to observe the airline.
        
        public Alert Alert
        {
            get => alert;
            set => alert = value;
        }

        public AirStation(string name, Radar radar, Alert alert)
        {
            this.name = name;
            this.radar = radar;
            this.alert = alert;

        }

        public string Name { get => name; set => name = value; }
        public Radar Radar { get => radar; set => radar = value; }
        
    }
}