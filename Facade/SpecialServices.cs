using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class SpecialServices
    {
        public bool ProvideSpecialServices(Customer customer)
        {
            Console.WriteLine("Providing special services for " + customer.Name + ".");
            return true; // Assume customer gets special services
        }
    }
}
