using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.FactoryMethod
{
    public interface ICar
    {
        void StartUp();
        void Run();
        void Stop();
    }
}
