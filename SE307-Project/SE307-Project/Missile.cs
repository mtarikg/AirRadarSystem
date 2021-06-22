namespace SE307_Project
{
    // declared abstract to prevent creating instances from this class, there might be missile types being added later.
    public abstract class Missile
    {
        private int id;
        private int positionX, positionY;

        protected Missile(int id, int positionX, int positionY)
        {
            this.id = id;
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public int Id { get => id; set => id = value; }
        public int PositionX { get => positionX; set => positionX = value; }
        public int PositionY { get => positionY; set => positionY = value; }
    }
}