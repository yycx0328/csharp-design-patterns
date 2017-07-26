using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.SimpleFactory
{
    public class America : ICountry
    {
        public void ShowHeadsOfState()
        {
            Console.WriteLine("美国最高元首是特朗普！");
        }
    }
}
