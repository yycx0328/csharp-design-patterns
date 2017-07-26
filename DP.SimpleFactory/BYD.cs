using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.SimpleFactory
{
    public class BYD : ICar
    {
        public void StartUp()
        {
            Console.WriteLine("启动比亚迪...");
        }


        public void Run()
        {
            Console.WriteLine("比亚迪跑起来了...");
        }

        public void Stop()
        {
            Console.WriteLine("停止比亚迪...");
        }
    }
}
