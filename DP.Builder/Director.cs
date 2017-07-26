using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Builder
{
    public class Director
    {
        public void BuildUp(IBuilder builder)
        {
            builder.BuildTires();
            builder.BuildEngine();
            builder.BuildDoor();
        }
    }
}
