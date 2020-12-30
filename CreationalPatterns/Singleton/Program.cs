using System;

namespace CreationalPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var database1 = Database.GetInstance();
            database1.Query("First query on the first database instance.");

            var database2 = Database.GetInstance();
            database2.Query("First query on the second database instance.");
        }
    }
}
