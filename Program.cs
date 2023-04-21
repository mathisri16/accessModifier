using System;
//using AfterBooking;
using Booking;

namespace Accessibility
{
    class program

    {
        static void Main(string[] args)
        {
            Login _Login = new Login();
            _Login.ALLowLogin("Sri", "password");
            
            BookingFunction _BookingFunction = new Airline();
            _BookingFunction.Book();
            _BookingFunction= new Bus();
            _BookingFunction.Book();

           

        }


    }
}
