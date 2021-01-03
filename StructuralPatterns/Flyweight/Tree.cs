namespace StructuralPatterns.Flyweight
{
    public class Tree
    {
        public int X { get; }
        public int Y { get; }
        // This is only a reference instead of storing all (name, color, texture) properties per tree
        public TreeType TreeType { get; }
        
        public Tree(int x, int y, TreeType treeType)
        {
            X = x;
            Y = y;
            TreeType = treeType;
        }

        public void Draw(string canvas)
        {
            TreeType.Draw(canvas, X, Y);
        }
    }
}
