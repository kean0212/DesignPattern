using System;

namespace StructuralPatterns.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var forest = new Forest();
            forest.PlantTree(0, 0, "0 name", "0 color", "0 texture");
            forest.PlantTree(1, 1, "1 name", "1 color", "1 texture");
            forest.PlantTree(2, 2, "2 name", "2 color", "2 texture");
            forest.PlantTree(3, 3, "3 name", "3 color", "3 texture");
            forest.Draw("initial canvas");
        }
    }
}
