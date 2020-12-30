namespace CreationalPatterns.Builder
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int count);
        void SetEngine(string name);
        void SetTripComputer();
        void SetGps();
    }
}
