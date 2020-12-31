namespace StructuralPatterns.Adapter
{
    public class RoundHole
    {
        public double Raidus { get; }

        public RoundHole(double raidus)
        {
            Raidus = raidus;
        }

        public bool Fits(RoundPeg roundPeg)
        {
            return Raidus >= roundPeg.Radius;
        }
    }
}
