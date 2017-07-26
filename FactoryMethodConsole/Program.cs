using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
using DP.FactoryMethod;

namespace FactoryMethodConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string CAR_FACTORY = ConfigurationManager.AppSettings["CAR_FACTORY"];

            string[] setting = CAR_FACTORY.Split(',');
            Assembly assembly = Assembly.Load(setting[0]);
            ICarFactory factory = (ICarFactory)assembly.CreateInstance(setting[1]);
            ICar car = factory.Create();
            car.StartUp();
            car.Run();
            car.Stop();
            Console.ReadKey();
        }
    }
}
