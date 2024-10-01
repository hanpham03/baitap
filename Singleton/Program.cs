using System;
using System.Collections.Generic;

namespace Singleton.RealWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Get the same instance of DatabaseManager
            DatabaseManager db1 = DatabaseManager.GetDatabaseManager();
            DatabaseManager db2 = DatabaseManager.GetDatabaseManager();
            DatabaseManager db3 = DatabaseManager.GetDatabaseManager();
            DatabaseManager db4 = DatabaseManager.GetDatabaseManager();

            // Check if they are the same instance
            if (db1 == db2 && db2 == db3 && db3 == db4)
            {
                Console.WriteLine("Same instance of DatabaseManager\n");
            }

            // Execute 10 queries
            for (int i = 0; i < 10; i++)
            {
                string connection = db1.ExecuteQuery("SELECT * FROM Users");
                Console.WriteLine("Query executed on: " + connection);
            }

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class DatabaseManager
    {
        // Singleton instance
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
