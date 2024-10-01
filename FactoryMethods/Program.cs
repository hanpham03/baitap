using FactoryMethods;
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

}

