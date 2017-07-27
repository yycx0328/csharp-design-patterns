﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Builder
{
    public class BMWBuilder:IBuilder
    {
        private ICar car = new BMW();

        public void BuildTires()
        {
            Console.WriteLine("安装宝马轮胎...");
        }

        public void BuildEngine()
        {
            Console.WriteLine("安装宝马引擎...");
        }

        public void BuildDoor()
        {
            Console.WriteLine("安装宝马车门...");
        }

        public ICar GetCar()
        {
            return car;
        }
    }
}
