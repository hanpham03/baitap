using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Builder.Structural
{
    public class MainApp
    {
        public static void Main()
        {
            // Create director and builders

            Director director = new Director();

            Builder carBuilder = new CarBuilder();
            Builder houseBuilder = new HouseBuilder();

            // Construct two products

            director.Construct(carBuilder);
            Product car = carBuilder.GetResult();
            Console.WriteLine("Car:");
            car.Show();

            director.Construct(houseBuilder);
            Product house = houseBuilder.GetResult();
            Console.WriteLine("House:");
            house.Show();

            Console.ReadKey();
        }
    }

    // The 'Director' class
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    // The 'Builder' abstract class
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }

    // The 'CarBuilder' class (ConcreteBuilder1)
    class CarBuilder : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("Engine");
        }

        public override void BuildPartB()
        {
            _product.Add("Wheels");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    // The 'HouseBuilder' class (ConcreteBuilder2)
    class HouseBuilder : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("Foundation");
        }

        public override void BuildPartB()
        {
            _product.Add("Roof");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    // The 'Product' class
    class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Product Parts -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
}

