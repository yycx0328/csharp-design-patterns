using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.SimpleFactory
{
    public class Russia : ICountry
    {
        public void ShowHeadsOfState()
        {
            Console.WriteLine("俄罗斯最高元首是普京！");
        }
    }
}
