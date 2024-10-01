using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class PaymentSystem
    {
        public bool ProcessPayment(Customer customer, int nights)
        {
            Console.WriteLine("Processing payment for " + customer.Name + " for " + nights + " nights.");
            return true; // Assume payment is successful
        }
    }
}
