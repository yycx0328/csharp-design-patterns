using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.FactoryMethod
{
    public class BMW:ICar
    {
        public void StartUp()
        {
            Console.WriteLine("启动宝马...");
        }
         
        public void Run()
        {
            Console.WriteLine("宝马跑起来了...");
        }

        public void Stop()
        {
            Console.WriteLine("停止宝马...");
        }
    }
}
