using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class CompositeElement : FileSystemElement
    {
        List<FileSystemElement> elements = new List<FileSystemElement>();

        // Constructor

        public CompositeElement(string name)
            : base(name)
        {
        }

        public override void Add(FileSystemElement d)
        {
            elements.Add(d);
        }

        public override void Remove(FileSystemElement d)
        {
            elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + "+ " + name);

            // Display each child element on this node

            foreach (FileSystemElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
}
