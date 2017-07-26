using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.SimpleFactory
{
    public class China : ICountry
    {
        public void ShowHeadsOfState()
        {
            Console.WriteLine("中国最高元首是习近平！");
        }
    }
}
