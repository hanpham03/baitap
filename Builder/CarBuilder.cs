using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class CarBuilder : Builders
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("Engine");
        }

        public override void BuildPartB()
        {
            _product.Add("Wheels");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
