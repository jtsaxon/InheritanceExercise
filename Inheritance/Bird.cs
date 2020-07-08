using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            LegCount = 2;
            EukaryoticCells = true;
            LandSeaAir = "Air";
            Age = 3;
        }

        public bool HasWings { get; set; }
        public bool HasBeak { get; set; }
        public string FeatherColor { get; set; }
        public string Species { get; set; }
    }
}
