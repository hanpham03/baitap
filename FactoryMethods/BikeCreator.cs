using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods
{
    internal class BikeCreator : Creator
    {
        public override Vehicle FactoryMethod()
        {
            return new Bike();
        }
    }
}
