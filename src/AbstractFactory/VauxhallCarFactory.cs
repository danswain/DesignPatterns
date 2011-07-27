namespace AbstractFactory
{
    public class VauxhallCarFactory : ICarFactory
    {
        public ICar Create()
        {
            return new VauxhallCar();
        }
    }
}