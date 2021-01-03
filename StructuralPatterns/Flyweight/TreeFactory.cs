using System.Collections.Generic;

namespace StructuralPatterns.Flyweight
{
    public class TreeFactory
    {
        private static Dictionary<string, TreeType> _nameToTreeType;

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            _nameToTreeType ??= new Dictionary<string, TreeType>();
            if (!_nameToTreeType.ContainsKey(name))
            {
                _nameToTreeType[name] = new TreeType(name, color, texture);
            }
            return _nameToTreeType[name];
        }
    }
}
