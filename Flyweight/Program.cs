using System;
using System.Collections.Generic;

namespace Flyweight.RealWorld
{
    /// <summary>
    /// Flyweight Design Pattern Example: Shape Drawing
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Define shapes to be drawn
            string[] shapes = { "Circle", "Square", "Circle", "Square", "Circle" };

            ShapeFactory factory = new ShapeFactory();

            // External property (e.g., size)
            int size = 5;

            // For each shape, use a flyweight object
            foreach (var shapeType in shapes)
            {
                size += 5;
                Shape shape = factory.GetShape(shapeType);
                shape.Draw(size);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
