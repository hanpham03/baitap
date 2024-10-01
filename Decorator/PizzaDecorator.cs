using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;

        // Constructor
        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string Description => pizza.Description;
        public override double Cost => pizza.Cost;

        public override void Display()
        {
            pizza.Display();
        }
    }
}
