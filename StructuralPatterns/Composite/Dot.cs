using System;

namespace StructuralPatterns.Composite
{
    public class Dot : IGraphic
    {
        private int _x;
        private int _y;

        public Dot(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"{nameof(Dot)}.{nameof(Draw)}");
        }

        public void Move(int x, int y)
        {
            _x += x;
            _y += y;
        }
    }
}
