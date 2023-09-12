using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section11
{
    //constructor
    internal class Lecture : Ticket
    {
        private string lecturerName;
        private string lectureSubject;

        public Lecture(string lEventType, double lTicketPrice, string lSeatNumber, DateTime lEventDate, string lEventLocation, string lLecturerName, string lLectureSubject)
        : base(lEventType, lTicketPrice, lSeatNumber, lEventDate, lEventLocation)
        {
            LecturerName = lLecturerName;
            LectureSubject = lLectureSubject;
        }
        public string LecturerName
        {
            get { return lecturerName; }
            set { lecturerName = value; }
        }

        public string LectureSubject
        {
            get; set;
        }
        public override string ToString()
        {
            string lectureInfo = $"\nProfessor: {LecturerName}" +
                $"\nSubject: {LectureSubject}";

            return base.ToString() + lectureInfo;
        }
    }

}

