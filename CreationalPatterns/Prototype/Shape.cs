namespace CreationalPatterns.Prototype
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        public Shape()
        {
        }

        // The private fields of the source are accessible.
        public Shape(Shape source)
        {
            X = source.X;
            Y = source.Y;
            Color = source.Color;
        }

        public abstract Shape Clone();
    }
}
