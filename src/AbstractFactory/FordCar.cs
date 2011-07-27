using System;

namespace AbstractFactory
{
    public class FordCar : ICar
    {
        public string Make{get { return "Ford"; }}
        public string Model { get { return "Focus"; } }

        public void Drive()
        {
            Console.WriteLine(string.Format("Driving {0} {1}", Make, Model));
        }
    }
}