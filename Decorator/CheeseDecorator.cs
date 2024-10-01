using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(Pizza pizza)
            : base(pizza)
        {
        }

        public override string Description => pizza.Description + ", Cheese";
        public override double Cost => pizza.Cost + 1.25;

        public override void Display()
        {
            Console.WriteLine($"{Description}, Cost: ${Cost}");
        }
    }
}
