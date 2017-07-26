using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Builder;

namespace BuilderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder = new BMWBuilder();
            Director director = new Director();
            director.BuildUp(builder);
            ICar car = builder.GetCar();
            car.ShowCar();
            Console.ReadKey();
        }
    }
}
