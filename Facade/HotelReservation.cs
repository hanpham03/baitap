using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class HotelReservation
    {
        RoomAvailability roomAvailability = new RoomAvailability();
        PaymentSystem paymentSystem = new PaymentSystem();
        SpecialServices specialServices = new SpecialServices();

        public bool MakeReservation(Customer customer, int nights)
        {
            Console.WriteLine("{0} is attempting to book a room for {1} nights.\n", customer.Name, nights);

            bool isReservationSuccessful = true;

            // Check availability
            if (!roomAvailability.HasAvailableRooms(nights))
            {
                isReservationSuccessful = false;
            }
            // Process payment
            else if (!paymentSystem.ProcessPayment(customer, nights))
            {
                isReservationSuccessful = false;
            }
            // Provide special services
            else if (!specialServices.ProvideSpecialServices(customer))
            {
                isReservationSuccessful = false;
            }

            return isReservationSuccessful;
        }
    }
}
