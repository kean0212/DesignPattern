using System;

namespace CreationalPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            
            var carBuilder = new CarBuilder();
            director.ConstructSportsCar(carBuilder);
            carBuilder.GetProduct();

            var manualBuilder = new CarManualBuilder();
            director.ConstructSportsCar(manualBuilder);
            manualBuilder.GetProduct();
        }
    }
}
