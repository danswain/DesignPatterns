namespace FactoryMethod
{
    public class FordFocusCarFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new FordFocus();
        }
    }
}