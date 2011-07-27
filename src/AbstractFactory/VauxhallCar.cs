using System;

namespace AbstractFactory
{
    public class VauxhallCar : ICar
    {
        public string Make { get { return "Vauxhall"; } }
        public string Model { get { return "Astra"; } }

        public void Drive()
        {
            Console.WriteLine(string.Format("Driving {0} {1}", Make, Model));
        }
    }
}