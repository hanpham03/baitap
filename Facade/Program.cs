using System;

namespace Facade.RealWorld
{
    /// <summary>
    /// Facade Design Pattern Example: Hotel Reservation System
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Facade
            HotelReservation reservation = new HotelReservation();

            // Make a reservation for the customer
            Customer customer = new Customer("John Doe");
            bool reservationSuccess = reservation.MakeReservation(customer, 3);

            Console.WriteLine("\n" + customer.Name + " has been " + (reservationSuccess ? "Successfully Booked" : "Rejected"));

            // Wait for user
            Console.ReadKey();
        }
    }

}
