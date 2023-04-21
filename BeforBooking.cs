using System;

namespace Booking
{
    public class Login
    {
        public void ALLowLogin(string username, string password)
        {
            bool isvalidated = isvalidate(username, password);
            Console.WriteLine("Logged in ");
        }


        private bool isvalidate(string username, string password)
        {
            return true;
        }
    }

    public class BookingFunction
    {
        public virtual void Book()
        {

        }

       private protected string getPassengerDetails()
        {
            return "Passenger Details";
        }
    }

    public class Airline : BookingFunction
    {
        public override void Book()
        {
            getPassengerDetails();
            Console.WriteLine("Airline Booked");
            Ticketcopy _ticketcopy = new Ticketcopy();
            _ticketcopy.showticketcopy();
        }
    }
    public class Bus : BookingFunction
    {
        public override void Book()
        {
            getPassengerDetails();
            Console.WriteLine("Bus Booked");
            Ticketcopy _ticketcopy = new Ticketcopy();
            _ticketcopy.showticketcopy();
        }
    }

    public class Ticketcopy
        {

       protected internal void showticketcopy()

        {
        Console.WriteLine("Ticket Copy");
        }

        }

}
