using System;

namespace StructuralPatterns.Composite
{
    public class Circle : Dot
    {
        private int _radius;

        public Circle(int x, int y, int radius) : base(x, y)
        {
            _radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"{nameof(Circle)}.{nameof(Draw)}");
        }
    }
}
