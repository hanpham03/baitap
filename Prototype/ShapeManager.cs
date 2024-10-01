using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class ShapeManager
    {
        private Dictionary<string, ShapePrototype> shapes = new Dictionary<string, ShapePrototype>();

        // Indexer
        public ShapePrototype this[string key]
        {
            get { return shapes[key]; }
            set { shapes.Add(key, value); }
        }
    }
}
