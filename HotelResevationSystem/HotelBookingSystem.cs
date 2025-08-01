using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelResevationSystem
{
    public class HotelBookingSystem
    {
        private readonly int roomCount;
        private readonly bool[,] occupancyMatrix;

        public HotelBookingSystem(int numberOfRooms)
        {
            if (numberOfRooms <= 0 || numberOfRooms > 1000)
                throw new ArgumentOutOfRangeException(nameof(numberOfRooms), "Hotel size must be within 1 to 1000.");

            roomCount = numberOfRooms;
            occupancyMatrix = new bool[roomCount, 365]; // max 365 columns count.
        }

        public BookingResponseType MakeReservation(int startDay, int endDay, BookingRequestType requestType = BookingRequestType.Standard)
        {
            // Validate date bounds.
            if (startDay < 0 || endDay >= 365 || startDay > endDay)
                return BookingResponseType.Declined;

            // Checking room availability.
            for (int room = 0; room < roomCount; room++)
            {
                bool available = true;
                for (int day = startDay; day <= endDay; day++)
                {
                    if (occupancyMatrix[room, day])
                    {
                        available = false;
                        break;
                    }
                }

                if (available)
                {
                    for (int day = startDay; day <= endDay; day++)
                        occupancyMatrix[room, day] = true;

                    return BookingResponseType.Accepted;
                }
            }

            return BookingResponseType.Declined;
        }
    }
}
