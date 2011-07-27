using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var carManufacturer = new CarManufacturer();

            var fordFiestaBuilder = new BlueFordFiestaBuilder();
            carManufacturer.Build(fordFiestaBuilder);
            Console.WriteLine(fordFiestaBuilder.Car);

            var fordFocusBuilder = new RedFordFocusBuilder();
            carManufacturer.Build(fordFocusBuilder);
            Console.WriteLine(fordFocusBuilder.Car);

            Console.ReadLine();
        }
    }
}
