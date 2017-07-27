using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Builder
{
    public class BenzBuilder : IBuilder
    {
        private ICar car = new Benz();

        public void BuildTires()
        {
            Console.WriteLine("安装奔驰轮胎...");
        }

        public void BuildEngine()
        {
            Console.WriteLine("安装奔驰引擎...");
        }

        public void BuildDoor()
        {
            Console.WriteLine("安装奔驰车门...");
        }

        public ICar GetCar()
        {
            return car;
        }
    }
}
