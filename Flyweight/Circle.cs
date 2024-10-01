using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Circle : Shape
    {
        // Constructor
        public Circle()
        {
            this.type = "Circle";
        }

        public override void Draw(int size)
        {
            Console.WriteLine(type + " with radius " + size);
        }
    }
}
