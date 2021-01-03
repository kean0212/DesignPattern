using System.Collections.Generic;

namespace StructuralPatterns.Flyweight
{
    public class Forest
    {
        private List<Tree> _trees = new List<Tree>();

        public void PlantTree(
            int x,
            int y,
            string name,
            string color,
            string texture)
        {
            var treeType = TreeFactory.GetTreeType(name, color, texture);
            _trees.Add(new Tree(x, y, treeType));
        }

        public void Draw(string canvas)
        {
            foreach (var tree in _trees)
            {
                tree.Draw(canvas);
            }
        }
    }
}
