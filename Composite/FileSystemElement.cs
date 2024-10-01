using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class FileSystemElement
    {
        protected string name;

        // Constructor

        public FileSystemElement(string name)
        {
            this.name = name;
        }

        public abstract void Add(FileSystemElement d);
        public abstract void Remove(FileSystemElement d);
        public abstract void Display(int indent);
    }
}
