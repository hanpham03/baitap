using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class DatabaseManager
    {
        private static DatabaseManager instance;

        // List of available connections
        private List<string> connections = new List<string>();

        // Random instance to simulate query execution on random connection
        private Random random = new Random();

        // Lock object for thread-safety
        private static object locker = new object();

        // Constructor (private to enforce Singleton pattern)
        private DatabaseManager()
        {
            // Initialize with available connections
            connections.Add("Database Connection 1");
            connections.Add("Database Connection 2");
            connections.Add("Database Connection 3");
            connections.Add("Database Connection 4");
        }

        // Get the single instance of DatabaseManager
        public static DatabaseManager GetDatabaseManager()
        {
            // Double-checked locking for thread safety
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new DatabaseManager();
                    }
                }
            }

            return instance;
        }

        // Method to simulate query execution on a random database connection
        public string ExecuteQuery(string query)
        {
            int r = random.Next(connections.Count);
            Console.WriteLine($"Executing query: \"{query}\"");
            return connections[r];
        }
    }
}
