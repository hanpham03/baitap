using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class HouseBuilder : Builders
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("Foundation");
        }

        public override void BuildPartB()
        {
            _product.Add("Roof");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
