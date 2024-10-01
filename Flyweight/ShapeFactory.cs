using Flyweight.RealWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class ShapeFactory
    {
        private Dictionary<string, Shape> shapes = new Dictionary<string, Shape>();

        public Shape GetShape(string key)
        {
            // Uses "lazy initialization"
            Shape shape = null;

            if (shapes.ContainsKey(key))
            {
                shape = shapes[key];
            }
            else
            {
                switch (key)
                {
                    case "Circle": shape = new Circle(); break;
                    case "Square": shape = new Square(); break;
                }
                shapes.Add(key, shape);
            }
            return shape;
        }
    }
}
