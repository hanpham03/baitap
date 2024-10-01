using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public abstract class Shape
    {
        protected string type;

        public abstract void Draw(int size);
    }
}
