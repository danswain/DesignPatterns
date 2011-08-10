using System;

namespace FactoryMethod
{
    public abstract class Car : ICar
    {
        public abstract string Make { get; }
        public abstract string Model { get; }
        public virtual void Drive()
        {
            Console.WriteLine(string.Format("Driving {0} {1}", Make, Model));
        }
    }
}