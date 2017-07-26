using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.FactoryMethod
{
    public class BenzFactory : ICarFactory
    {
        public ICar Create()
        {
            return new Benz();
        }
    }
}
