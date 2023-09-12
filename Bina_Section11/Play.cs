using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section11
{
    internal class Play:Ticket
    {
        private string playName;
        private string playActorName;
        public Play(string pEventType, double pTicketPrice, string pSeatNumber, DateTime pEventDate, string pEventLocation, string pName, string pActorName)
            : base(pEventType, pTicketPrice, pSeatNumber, pEventDate, pEventLocation)
        {
            PlayName = pName;
            PlayActorName = pActorName;
        }

        public string PlayName
        {
            get;set;
        }

        public string PlayActorName
        {
            get { return playActorName; }
            set { playActorName = value; }
        }
        public override string ToString()
        {
            string playInfo = $"\nPlay Name: {PlayName}" +
                 $"\nActor: {PlayActorName}";

            return base.ToString()+playInfo;
        }
    }
}
