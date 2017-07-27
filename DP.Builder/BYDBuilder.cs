using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Builder
{
    public class BYDBuilder : IBuilder
    {
        private ICar car = new BYD();

        public void BuildTires()
        {
            Console.WriteLine("安装比亚迪轮胎...");
        }

        public void BuildEngine()
        {
            Console.WriteLine("安装比亚迪引擎...");
        }

        public void BuildDoor()
        {
            Console.WriteLine("安装比亚迪车门...");
        }

        public ICar GetCar()
        {
            return car;
        }
    }
}
