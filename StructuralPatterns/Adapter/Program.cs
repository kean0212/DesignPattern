using System;

namespace StructuralPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var hole = new RoundHole(5);
            var roundPeg = new RoundPeg(5);
            Console.WriteLine($"The hole fits the round peg: {hole.Fits(roundPeg)}");

            var smallSquarePeg = new SquarePeg(5);
            var bigSquarePeg = new SquarePeg(10);
            //hole.Fits(smallSquarePeg); // this line won't compile due to incompatible type

            var smallSquarePegAdapter = new SquarePegAdapter(smallSquarePeg);
            Console.WriteLine($"The hole fits the small square peg: {hole.Fits(smallSquarePegAdapter)}");
            var bigSquarePegAdapter = new SquarePegAdapter(bigSquarePeg);
            Console.WriteLine($"The hole fits the big square peg: {hole.Fits(bigSquarePegAdapter)}");
        }
    }
}
