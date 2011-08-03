namespace AbstractFactory
{
    public class FordFestaCarFactory : ICarFactory
    {
 
 

        public ICar CreateHatchback()
        {
            return new FordFiestaHatchBack();
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