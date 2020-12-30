using System;

namespace CreationalPatterns.Builder
{
    public class CarBuilder : IBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _car = new Car();
        }

        public void SetEngine(string name)
        {
            Console.WriteLine($"{nameof(CarBuilder)}:{nameof(SetEngine)}({name})");
        }

        public void SetGps()
        {
            Console.WriteLine($"{nameof(CarBuilder)}:{nameof(SetGps)}");
        }

        public void SetSeats(int count)
        {
            Console.WriteLine($"{nameof(CarBuilder)}:{nameof(SetSeats)}({count})");
        }

        public void SetTripComputer()
        {
            Console.WriteLine($"{nameof(CarBuilder)}:{nameof(SetTripComputer)}");
        }

        public Car GetProduct()
        {
            var result = _car;
            Reset();
            return result;
        }
    }
}
