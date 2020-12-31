using System;
using System.Collections.Generic;

namespace StructuralPatterns.Composite
{
    public class CompoundGraphic : IGraphic
    {
        private List<IGraphic> _children;

        public void Add(IGraphic child)
        {
            _children.Add(child);
        }

        public void Remove(IGraphic child)
        {
            if (child == null)
            {
                return;
            }

            _children.Remove(child);
        }

        public void Draw()
        {
            Console.WriteLine($"{nameof(CompoundGraphic)}.{nameof(Draw)}");
        }

        public void Move(int x, int y)
        {
            foreach (var child in _children)
            {
                child.Move(x, y);
            }
        }
    }
}
