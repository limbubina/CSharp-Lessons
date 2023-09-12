using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section11
{
    abstract class Ticket
    {
        private string eventType;
        private double ticketPrice;
        private string seatNumber;
        private string eventLocation;
        protected DateTime eventDate;

        //constructor
        public Ticket(string eventType, double ticketPrice, string seatNumber, DateTime eventDate, string eventLocation)
        {
            EventType = eventType;
            TicketPrice = ticketPrice;
            SeatNumber = seatNumber;
            EventDate = eventDate;
            EventLocation = eventLocation;
        }

        //Properties
        public string EventType
        {
            get; set;
        }
        public double TicketPrice
        {
            get; set;
        }
        public string SeatNumber
        {
            get; set;
        }
        public string EventLocation
        {
            get
            {
                return eventLocation;
            }
            set
            {
                eventLocation = value;
            }
        }

        public DateTime EventDate
        {
            get; set;
        }

        //public abstract string GetEventInfo();

        public override string ToString()
        {
            string result = $"Event type: {EventType}" +
               $"\nEvent Cost: {TicketPrice:C} " +
               $"\nSeatNumber: {SeatNumber}" +
               $"\nEvent Location: {EventLocation}";

            return result;
        }
    }
}
