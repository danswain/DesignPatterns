using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            var fordFiesta = new FordFiestaBuilder()
                .AddAlarm(true)
                .AddDoors(5)
                .AddSatNav(true)
                .AddEngine("2.8")
                .CarBody("Convertible")
                .PaintColor("Red")
                .AddSatNav(true)
                .AddSunroof(true)
                .Mp3Player(true)
                .Build();

            Console.WriteLine(fordFiesta);

            Console.ReadLine();
        }
    }
}
