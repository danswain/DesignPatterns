namespace AbstractFactory
{
    public interface ICarFactory
    {
        ICar CreateHatchback();
        ICar CreateEstate();
        ICar CreateConvertible();
    }
}