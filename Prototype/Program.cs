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

    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    public abstract class ShapePrototype
    {
        public abstract ShapePrototype Clone();
        public abstract void Show();
    }

    /// <summary>
    /// ConcretePrototype class: Circle
    /// </summary>
    public class Circle : ShapePrototype
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

    /// <summary>
    /// ConcretePrototype class: Rectangle
    /// </summary>
    public class Rectangle : ShapePrototype
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

    /// <summary>
    /// Prototype manager
    /// </summary>
    public class ShapeManager
    {
        private Dictionary<string, ShapePrototype> shapes = new Dictionary<string, ShapePrototype>();

        // Indexer
        public ShapePrototype this[string key]
        {
            get { return shapes[key]; }
            set { shapes.Add(key, value); }
        }
    }
}
