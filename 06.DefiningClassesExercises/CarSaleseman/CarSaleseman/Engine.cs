﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaleseman
{
    public class Engine
    {
        public Engine()
        {
            
        }
        public Engine(string model, int power) : this()
        {
            Model = model;
            Power = power;
        }
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
