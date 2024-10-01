using System;
using System.Collections.Generic;

namespace Prototype.RealWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShapeManager shapeManager = new ShapeManager();

            // Initialize with standard shapes
            shapeManager["Circle"] = new Circle(10);
            shapeManager["Rectangle"] = new Rectangle(5, 7);

            // User adds personalized shapes
            shapeManager["LargeCircle"] = new Circle(20);
            shapeManager["SmallRectangle"] = new Rectangle(2, 3);

            // User clones selected shapes
            Circle shape1 = shapeManager["Circle"].Clone() as Circle;
            Rectangle shape2 = shapeManager["SmallRectangle"].Clone() as Rectangle;

            // Output
            shape1.Show();
            shape2.Show();

            Console.ReadKey();
        }
    }
}
