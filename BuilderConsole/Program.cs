using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Builder;
using System.Reflection;

namespace BuilderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string BUILDER = ConfigurationManager.AppSettings["BUILDER"];

            string[] setting = BUILDER.Split(',');
            Director director = new Director();
            Assembly assembly = Assembly.Load(setting[0]);
            IBuilder builder = (IBuilder)assembly.CreateInstance(setting[1]);
            director.BuildUp(builder);
            ICar car = builder.GetCar();
            car.ShowCar();
            Console.ReadKey();
        }
    }
}
