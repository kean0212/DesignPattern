using System;
using System.Collections.Generic;

namespace CreationalPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            // Create a circle object
            var circle = new Circle();
            circle.X = 10;
            circle.Y = 10;
            circle.Radius = 20;
            circle.Color = "Blue";
            shapes.Add(circle);

            // Get a clone
            var anotherCircle = circle.Clone();
            shapes.Add(anotherCircle);

            // Create a rectangle
            var rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 20;
            shapes.Add(rectangle);

            // Copy all shapes in the list
            var shapesCopy = new List<Shape>();
            foreach (var shape in shapes)
            {
                shapesCopy.Add(shape.Clone());
            }
        }
    }
}
