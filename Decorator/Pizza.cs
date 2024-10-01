using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Pizza
    {
        public abstract string Description { get; }
        public abstract double Cost { get; }

        public abstract void Display();
    }
}
