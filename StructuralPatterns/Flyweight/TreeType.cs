using System;

namespace StructuralPatterns.Flyweight
{
    // This class represents the flyweight class which takes a lot of RAM
    public class TreeType
    {
        public string Name { get; }
        public string Color { get; }
        public string Texture { get; }

        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
        }

        public void Draw(object canvas, int x, int y)
        {
            Console.WriteLine($"Draw a tree of (name: {Name}, color: {Color}, texture: {Texture}) at ({x}, {y}) on {canvas}");
        }
    }
}
