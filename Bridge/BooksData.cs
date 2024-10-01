using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class BooksData :  DataObject
    {
        private readonly List<string> books = new List<string>();
        private int current = 0;
        private string libraryName;

        public BooksData(string libraryName)
        {
            this.libraryName = libraryName;

            // Loaded from a database or some data source

            books.Add("To Kill a Mockingbird");
            books.Add("1984");
            books.Add("The Great Gatsby");
            books.Add("Moby Dick");
            books.Add("War and Peace");
        }

        public override void NextRecord()
        {
            if (current <= books.Count - 1)
            {
                current++;
            }
        }

        public override void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }

        public override void AddRecord(string book)
        {
            books.Add(book);
        }

        public override void DeleteRecord(string book)
        {
            books.Remove(book);
        }

        public override string GetCurrentRecord()
        {
            return books[current];
        }

        public override void ShowRecord()
        {
            Console.WriteLine(books[current]);
        }

        public override void ShowAllRecords()
        {
            Console.WriteLine("Library: " + libraryName);

            foreach (string book in books)
            {
                Console.WriteLine(" " + book);
            }
        }
    }
}
