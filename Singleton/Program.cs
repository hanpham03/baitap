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
}
