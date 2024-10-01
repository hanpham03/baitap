using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class PlainPizza : Pizza
    {
        public override string Description => "Plain Pizza";
        public override double Cost => 5.00;

        public override void Display()
        {
            Console.WriteLine($"{Description}, Cost: ${Cost}");
        }
    }
}
