using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class PepperoniDecorator : PizzaDecorator
    {
        public PepperoniDecorator(Pizza pizza)
            : base(pizza)
        {
        }

        public override string Description => pizza.Description + ", Pepperoni";
        public override double Cost => pizza.Cost + 1.50;

        public override void Display()
        {
            Console.WriteLine($"{Description}, Cost: ${Cost}");
        }
    }
}
