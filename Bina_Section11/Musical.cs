using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section11
{
    internal class Musical : Ticket
    {
        private string musicalName;
        private string musicalArtist;

        //constructor
        public Musical(string mEventType, double mTicketPrice, string mSeatNumber, DateTime mEventDate, string mEventLocation, string mName, string mArtist)
            : base(mEventType, mTicketPrice, mSeatNumber, mEventDate, mEventLocation)
        {
            MusicalName = mName;
            MusicalArtist = mArtist;
        }

        public string MusicalName
        {
            get; set;
        }

        public string MusicalArtist
        {
            get; set;
        }

        public override string ToString()
        {
            string musicalInfo = $"\nMusical Name: {MusicalName}" +
                $"\nArtist: {MusicalArtist}";

            return base.ToString() + musicalInfo;
        }
    }

}


