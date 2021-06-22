namespace SE307_Project
{
    public class Radar
    {
        private double highRiskRadius, lowRiskRadius;
        private bool isThereRisk;

        public Radar(double highRiskRadius, double lowRiskRadius)
        {
            this.highRiskRadius = highRiskRadius;
            this.lowRiskRadius = lowRiskRadius;
        }

        public void saveIntoLogs(AirCraft airCraft)
        {
            
        }

        public void createNewLog()
        {
            
        }

        public bool RiskChecker(AirCraft airCraft)
        {
            return false;
        }

        public bool isEnemyChecker(AirCraft airCraft)
        {
            return false;
        }

        public Radar()
        {
        }
    }
}