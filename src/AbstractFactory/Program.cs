using System;

namespace AbstractFactory
{
    public class Program
    {
        public Program(ICarFactory factory)
        {
            ICar myNewCar = factory.Create();
            myNewCar.Drive();
        }
        static void Main(string[] args)
        {
            new Program(new FordCarFactory()); //Prints Driving Ford Focus
            new Program(new VauxhallCarFactory()); //Prints Driving Vauxhall Astra

            Console.ReadLine();
        }
    }
}
