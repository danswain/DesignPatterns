namespace AbstractFactory
{
    public class FordFiestaFactory : ICarFactory
    {
 
        public ICar CreateHatchback()
        {
            return new FordFiestaHatchback();
        }

        public ICar CreateEstate()
        {
            return new FordFiestaEstate();
        }

        public ICar CreateConvertible()
        {
            return new FordFiestaConvertible();
        }

        
    }
}