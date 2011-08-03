using System;

namespace AbstractFactory
{
    public abstract class Car : ICar
    {
        public abstract string Make { get; }
        public abstract string Model { get; }
        public abstract string BodyType { get; }
        public virtual void Drive()
        {
            Console.WriteLine(string.Format("Driving {0} {1} {2}", Make, Model, BodyType));
        }
    }
}