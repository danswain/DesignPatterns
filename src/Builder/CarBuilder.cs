namespace Builder
{
    public abstract class CarBuilder
    {
        protected Car car;

        public CarBuilder()
        {
            car = new Car();
        }

        public Car Car
        {
            get { return car; }
        }

        public abstract void BuildCarBody();
        public abstract void PaintColor();
        public abstract void AddDoors();
        public abstract void AddEngine();
    }
}