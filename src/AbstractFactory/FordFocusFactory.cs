using System;

namespace AbstractFactory
{
    internal class FordFocusFactory : ICarFactory
    {
        public ICar CreateHatchback()
        {
            return new FordFocusHatchback();
        }

        public ICar CreateEstate()
        {
            return new FordFocusEstate();
        }

        public ICar CreateConvertible()
        {
            return new FordFocusConvertible();
        }
    }
}