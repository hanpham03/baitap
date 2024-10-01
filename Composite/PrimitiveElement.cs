using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class PrimitiveElement : FileSystemElement
    {
        // Constructor

        public PrimitiveElement(string name)
            : base(name)
        {
        }

        public override void Add(FileSystemElement c)
        {
            Console.WriteLine("Cannot add to a file.");
        }

        public override void Remove(FileSystemElement c)
        {
            Console.WriteLine("Cannot remove from a file.");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + name);
        }
    }
}
