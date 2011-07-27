namespace AbstractFactory
{
    public class FordCarFactory : ICarFactory
    {
        public ICar Create()
        {
            return new FordCar();
        }
    }
}