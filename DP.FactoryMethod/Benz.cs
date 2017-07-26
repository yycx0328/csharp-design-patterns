using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.FactoryMethod
{
    public class Benz : ICar
    {
        public void StartUp()
        {
            Console.WriteLine("启动奔驰...");
        }

        public void Run()
        {
            Console.WriteLine("奔驰跑起来了...");
        }

        public void Stop()
        {
            Console.WriteLine("停止奔驰...");
        }
    }
}
