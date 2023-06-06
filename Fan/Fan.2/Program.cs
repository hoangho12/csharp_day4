using System;

namespace Fan._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan()
            {
                Speed = Fan.Fast,
                Radius = 10,
                Color = "yellow",
                On = true
            };

            Fan fan2 = new Fan()
            {
                Speed = Fan.Medium,
                Radius = 5,
                Color = "blue",
                On = false
            };

            Console.WriteLine(fan1.GetFanInfo());
            Console.WriteLine(fan2.GetFanInfo());

            Console.ReadKey();
        }
    }
}
