using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResevationSystem
{
    public class HotelBookingSystemTests
    {
        public static void Run()
        {
            Console.WriteLine(" Hotel Reservation Edge Case Tests:\n");

            Console.WriteLine("\n");

            Console.WriteLine("-- Case 1: Out-of-bounds check --");

            // Case 1: Out-of-bounds check.
            var hotel1 = new HotelBookingSystem(1);
            Console.WriteLine(hotel1.MakeReservation(-4, 2)); // Declined
            Console.WriteLine(hotel1.MakeReservation(200, 400)); // Declined

            Console.WriteLine("\n");

            Console.WriteLine("-- Case 2: Valid Requests (Size=3) --");

            // Case 2: Valid Requests (Size=3)
            var hotel2 = new HotelBookingSystem(3);
            Console.WriteLine(hotel2.MakeReservation(0, 5)); // Accepted
            Console.WriteLine(hotel2.MakeReservation(7, 13)); // Accepted
            Console.WriteLine(hotel2.MakeReservation(3, 9)); // Accepted
            Console.WriteLine(hotel2.MakeReservation(5, 7)); // Accepted
            Console.WriteLine(hotel2.MakeReservation(6, 6)); // Accepted
            Console.WriteLine(hotel2.MakeReservation(0, 4)); // Accepted

            Console.WriteLine("\n");

            Console.WriteLine("-- Case 3: One Declined --");

            // Case 3: One Declined
            var hotel3 = new HotelBookingSystem(3);
            Console.WriteLine(hotel3.MakeReservation(1, 3)); // Accepted
            Console.WriteLine(hotel3.MakeReservation(2, 5)); // Accepted
            Console.WriteLine(hotel3.MakeReservation(1, 9)); // Accepted
            Console.WriteLine(hotel3.MakeReservation(0, 15)); // Declined

            Console.WriteLine("\n");

            Console.WriteLine("-- Case 4: Accept After Decline --");

            // Case 4: Accept After Decline
            var hotel4 = new HotelBookingSystem(3);
            Console.WriteLine(hotel4.MakeReservation(1, 3)); // Accepted
            Console.WriteLine(hotel4.MakeReservation(0, 15)); // Accepted
            Console.WriteLine(hotel4.MakeReservation(1, 9)); // Accepted
            Console.WriteLine(hotel4.MakeReservation(2, 5)); // Declined
            Console.WriteLine(hotel4.MakeReservation(4, 9)); // Accepted

            Console.WriteLine("\n");

            Console.WriteLine("-- Case 5: Complex Overlaps --");

            // Case 5: Complex Overlaps
            var hotel5 = new HotelBookingSystem(2);
            Console.WriteLine(hotel5.MakeReservation(1, 3)); // Accepted
            Console.WriteLine(hotel5.MakeReservation(0, 4)); // Accepted
            Console.WriteLine(hotel5.MakeReservation(2, 3)); // Declined
            Console.WriteLine(hotel5.MakeReservation(5, 5)); // Accepted
            Console.WriteLine(hotel5.MakeReservation(4, 10)); // Accepted
            Console.WriteLine(hotel5.MakeReservation(10, 10)); // Accepted
            Console.WriteLine(hotel5.MakeReservation(6, 7)); // Accepted
            Console.WriteLine(hotel5.MakeReservation(8, 10)); // Declined
            Console.WriteLine(hotel5.MakeReservation(8, 9)); // Accepted
        }
    }
}
