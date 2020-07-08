using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var bird1 = new Bird();
            bird1.Species = "Cardinal";
            bird1.FeatherColor = "Red";
            bird1.HasWings = true;
            bird1.HasBeak = true;

            var bird2 = new Bird()
            {
                Species = "Oriole",
                FeatherColor = "Orange",
                HasWings = true,
                HasBeak = true
            };

            var reptile1 = new Reptile();
            reptile1.IsColdBlooded = true;
            reptile1.HasScales = true;
            reptile1.ScaleColor = "Green";
            reptile1.TailLength = 10.7;

            var reptile2 = new Reptile()
            {
                IsColdBlooded = true,
                HasScales = true,
                ScaleColor = "Black",
                TailLength = 6.9
            };

            var myAnimals = new Animal[] { bird1, bird2, reptile1, reptile2 };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"The animal is {animal.Age} years old.");
                Console.WriteLine($"It has {animal.LegCount} legs.");
                Console.WriteLine($"Has eukaryotic cells? {animal.EukaryoticCells}");
                Console.WriteLine($"The animals habitat is... {animal.LandSeaAir}");
                Console.WriteLine($"");
            }

            Console.WriteLine($"Is the Iguana cold blooded? {reptile1.IsColdBlooded}");
            Console.WriteLine($"What color is the Iguana? {reptile1.ScaleColor}");

            Console.WriteLine($"The snake is {reptile2.ScaleColor}");
            Console.WriteLine($"Does the snake have scales? {reptile2.HasScales}");

            Console.WriteLine($"The {bird1.FeatherColor} {bird1.Species} lives in the {bird2.LandSeaAir}");

            Console.WriteLine($"The {bird2.FeatherColor} {bird2.Species} has {bird2.LegCount} legs.");

        }
    }
}
