using System;

namespace StructuralPatterns.Adapter
{
    public class SquarePegAdapter : RoundPeg
    {
        private readonly SquarePeg _squarePeg;

        public SquarePegAdapter(SquarePeg squarePeg)
            : base(squarePeg.Width * Math.Sqrt(2) / 2)
        {
            _squarePeg = squarePeg;
        }
    }
}
