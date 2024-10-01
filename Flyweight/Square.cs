using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Square : Shape
    {
        // Constructor
        public Square()
        {
            this.type = "Square";
        }

        public override void Draw(int size)
        {
            Console.WriteLine(type + " with side length " + size);
        }
    }
}
