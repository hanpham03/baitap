using System;
using System.Collections.Generic;

namespace Composite.RealWorld
{
    /// <summary>
    /// Composite Design Pattern Example: File System
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a tree structure

            CompositeElement root = new CompositeElement("Root Folder");
            root.Add(new PrimitiveElement("File1.txt"));
            root.Add(new PrimitiveElement("File2.txt"));

            // Create a branch (subfolder)

            CompositeElement subFolder = new CompositeElement("Sub Folder");
            subFolder.Add(new PrimitiveElement("File3.txt"));
            subFolder.Add(new PrimitiveElement("File4.txt"));

            // Add subfolder to the root folder

            root.Add(subFolder);

            // Add another file and remove one

            PrimitiveElement tempFile = new PrimitiveElement("TempFile.tmp");
            root.Add(tempFile);
            root.Remove(tempFile);

            // Recursively display nodes

            root.Display(1);

            // Wait for user

            Console.ReadKey();
        }
    }
}
