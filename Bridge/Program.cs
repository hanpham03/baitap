using System;
using System.Collections.Generic;

namespace Bridge.RealWorld
{
    /// <summary>
    /// Bridge Design Pattern Example: Library Book System
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create RefinedAbstraction

            var library = new Library();

            // Set ConcreteImplementor

            library.Data = new BooksData("Public Library");

            // Exercise the bridge

            library.Show();
            library.Next();
            library.Show();
            library.Next();
            library.Show();
            library.Add("The Catcher in the Rye");

            library.ShowAll();

            // Wait for user

            Console.ReadKey();
        }
    }

}

