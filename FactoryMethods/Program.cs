using System;

namespace DoFactory.GangOfFour.Factory.Structural
{
    class MainApp
    {
        static void Main()
        {
            // Mảng các Creator cụ thể (nhà sản xuất phương tiện)

            Creator[] creators = new Creator[2];

            creators[0] = new CarCreator();
            creators[1] = new BikeCreator();

            // Lặp qua từng creator và tạo sản phẩm (phương tiện)

            foreach (Creator creator in creators)
            {
                Vehicle vehicle = creator.FactoryMethod();
                Console.WriteLine("Created {0}", vehicle.GetType().Name);
            }

            Console.ReadKey();
        }
    }

    // Lớp Product (Vehicle - Phương tiện)
    abstract class Vehicle
    {
    }

    // ConcreteProduct: Car
    class Car : Vehicle
    {
    }

    // ConcreteProduct: Bike
    class Bike : Vehicle
    {
    }

    // Creator abstract class (nhà sản xuất phương tiện)
    abstract class Creator
    {
        public abstract Vehicle FactoryMethod();
    }

    // ConcreteCreator: CarCreator (Nhà sản xuất xe hơi)
    class CarCreator : Creator
    {
        public override Vehicle FactoryMethod()
        {
            return new Car();
        }
    }

    // ConcreteCreator: BikeCreator (Nhà sản xuất xe đạp)
    class BikeCreator : Creator
    {
        public override Vehicle FactoryMethod()
        {
            return new Bike();
        }
    }
}

