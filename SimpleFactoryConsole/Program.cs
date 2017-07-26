using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.SimpleFactory;

namespace SimpleFactoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            ICar car = factory.CreateInstance();
            car.StartUp();
            car.Run();
            car.Stop();
            Console.ReadKey();
        }
    }
}
