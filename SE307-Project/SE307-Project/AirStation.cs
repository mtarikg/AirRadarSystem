namespace SE307_Project
{
    public class AirStation
    {
        private string name;
        private Radar radar; // an air station must have a radar to observe the airline.
        // an air station must have a missile station to fire missiles in case the radar identifies an enemy.
        private MissilesStation missilesStation;

        public AirStation(string name, Radar radar, MissilesStation missilesStation)
        {
            this.name = name;
            this.radar = radar;
            this.missilesStation = missilesStation;
        }

        public string Name { get => name; set => name = value; }
        public Radar Radar { get => radar; set => radar = value; }
        public MissilesStation MissilesStation { get => missilesStation; set => missilesStation = value; }
    }
}