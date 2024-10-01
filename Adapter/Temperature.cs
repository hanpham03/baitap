using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Temperature
    {
        protected double celsius;

        public virtual void Display()
        {
            Console.WriteLine("\nTemperature: Unknown ------ ");
        }
    }
}
