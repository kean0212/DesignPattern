using System;

namespace CreationalPatterns.Singleton
{
    public class Database
    {
        private static Database instance;

        private Database()
        {
        }

        public static Database GetInstance()
        {
            instance ??= new Database();
            return instance;
        }

        public void Query(string query)
        {
            Console.WriteLine($"Query: {query}");
        }
    }
}
