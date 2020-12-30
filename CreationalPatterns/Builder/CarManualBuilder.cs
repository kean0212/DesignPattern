using System;

namespace CreationalPatterns.Builder
{
    public class CarManualBuilder : IBuilder
    {
        private Manual _manual;

        public void Reset()
        {
            _manual = new Manual();
        }

        public void SetEngine(string name)
        {
            Console.WriteLine($"{nameof(CarManualBuilder)}:{nameof(SetEngine)}({name})");
        }

        public void SetGps()
        {
            Console.WriteLine($"{nameof(CarManualBuilder)}:{nameof(SetGps)}");
        }

        public void SetSeats(int count)
        {
            Console.WriteLine($"{nameof(CarManualBuilder)}:{nameof(SetSeats)}:({count})");
        }

        public void SetTripComputer()
        {
            Console.WriteLine($"{nameof(CarManualBuilder)}:{nameof(SetTripComputer)}");
        }

        public Manual GetProduct()
        {
            var result = _manual;
            Reset();
            return result;
        }
    }
}
