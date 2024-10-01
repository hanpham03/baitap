using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Circle : ShapePrototype
    {
        int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override ShapePrototype Clone()
        {
            Console.WriteLine("Cloning Circle with radius: {0}", radius);
            return this.MemberwiseClone() as ShapePrototype;
        }

        public override void Show()
        {
            Console.WriteLine("Circle with radius: {0}", radius);
        }
    }
}
