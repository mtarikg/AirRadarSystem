namespace SE307_Project
{
    public interface ICalculationService
    {
        void CalcDistance(AirCraft airCraft,Missile missile,MissilesStation missilesStation);
        void CalcTime(AirCraft airCraft);
        
    }
}