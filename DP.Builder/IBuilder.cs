using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Builder
{
    public interface IBuilder
    {
        // 构建轮胎
        void BuildTires();
        // 构建引擎
        void BuildEngine();
        // 构建车门
        void BuildDoor();

        ICar GetCar();
    }
}
