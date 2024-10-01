﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Customer
    {
        private string name;

        // Constructor
        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
