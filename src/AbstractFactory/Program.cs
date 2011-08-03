using System;

namespace AbstractFactory
{
    public class Program
    {
        public Program(ICarFactory factory)
        {
            ICar hatchback = factory.CreateHatchback();
            hatchback.Drive();

            ICar estate = factory.CreateEstate();
            estate.Drive();

            ICar convertible = factory.CreateConvertible();
            convertible.Drive();
            Console.WriteLine("---------------------");
        }
        static void Main(string[] args)
        {
            new Program(new FordFiestaFactory()); //Prints Driving Ford Fiesta            
            new Program(new FordFocusFactory()); //Prints Driving Ford Focus            
            Console.ReadLine();
        }
    }
}
