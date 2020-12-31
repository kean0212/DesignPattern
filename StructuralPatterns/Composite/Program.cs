using System;
using System.Collections.Generic;

namespace StructuralPatterns.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class ImageEditor
    {
        private List<IGraphic> _all;

        public void Load()
        {
            _all ??= new List<IGraphic>();
            _all.Add(new CompoundGraphic());
            _all.Add(new Dot(1, 2));
            _all.Add(new Circle(5, 3, 10));
        }

        public void GroupSelected(IGraphic[] components)
        {
            // Group all selected components to a single compound graphic
            var group = new CompoundGraphic();
            foreach (var component in components)
            {
                group.Add(component);
                _all.Remove(component);
            }
            _all.Add(group);

            // Draw all graphics
            foreach (var graphic in _all)
            {
                graphic.Draw();
            }
        }
    }
}
