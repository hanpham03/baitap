using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Rectangle : ShapePrototype
    {
        int width;
        int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override ShapePrototype Clone()
        {
            Console.WriteLine("Cloning Rectangle with width: {0} and height: {1}", width, height);
            return this.MemberwiseClone() as ShapePrototype;
        }

        public override void Show()
        {
            Console.WriteLine("Rectangle with width: {0}, height: {1}", width, height);
        }
    }
}
