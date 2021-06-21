namespace SE307_Project
{
    public class Missile
    {
        private double speed;
        private int positionX, positionY;

        public void move()
        {
            
        }

        public Missile(double speed, int positionX, int positionY)
        {
            this.speed = speed;
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public Missile()
        {
        }
    }
}