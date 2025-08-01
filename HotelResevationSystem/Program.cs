using HotelResevationSystem;
using System;
using System.Collections.Generic;
public enum BookingRequestType
{
    Standard // Considered one room type.
}

public enum BookingResponseType
{
    Accepted,
    Declined
}

public class HotelBookingApp
{
    public static void Main()
    {
        HotelBookingSystemTests.Run();
    }
}