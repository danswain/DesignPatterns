using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        Program(ICarFactory carFactory)
        {                 
            var car = carFactory.CreateCar();
            car.Drive();            
        }


        static void Main(string[] args)
        {
            new Program(new FordFiestaCarFactory());
            new Program(new FordFocusCarFactory());
            Console.WriteLine("--------------");
            Console.ReadLine();
        }
    }


}
