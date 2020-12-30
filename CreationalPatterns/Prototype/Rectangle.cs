namespace CreationalPatterns.Prototype
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(Rectangle source) : base(source)
        {
            Width = source.Width;
            Height = source.Height;
        }

        public override Shape Clone()
        {
            // The object to be cloned takes an active role.
            return new Rectangle(this);
        }
    }
}
