using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        { 
            LegCount = 4;
            EukaryoticCells = true;
            LandSeaAir = "Land";
            Age = 5;    
        }

        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public string ScaleColor { get; set; }
        public double TailLength { get; set; } 
    }
}
