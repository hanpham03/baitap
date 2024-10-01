using Builder;
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

            Builders carBuilder = new CarBuilder();
            Builders houseBuilder = new HouseBuilder();

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
}

