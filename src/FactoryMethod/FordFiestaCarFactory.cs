namespace FactoryMethod
{
    public class FordFiestaCarFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new FordFiesta();
        }
    }
}