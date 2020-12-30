namespace CreationalPatterns.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetEngine("SportsCar");
            builder.SetSeats(2);
            builder.SetTripComputer();
            builder.SetGps();
        }
    }
}
