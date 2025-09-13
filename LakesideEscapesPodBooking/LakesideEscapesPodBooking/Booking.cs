using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakesideEscapesPodBooking
{
    internal class Booking
    {
        //lists for combobox
        public static List<string> trueOrfalse = new List<string>() { "True", "False" };
        public static List<string> podTypes = new List<string>() { "Standard", "Luxury" };
        //characteristics
        private string podType;
        private int bookingID;
        private DateTime startDate;
        private DateTime endDate;
        private int noOfOccupants;
        private int podID;
        private string depositPaid;
        private string attendingCourse;
        private DateTime dateBooked;
        private int guestID;

        //constructor to create booking
        public Booking(DateTime startDate, DateTime endDate, int noOfOccupants,
            int podID, string depositPaid, string attendingCourse, DateTime dateBooked,
            int guestID)
        { 
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.NoOfOccupants = noOfOccupants;
            this.PodID = podID;
            this.DepositPaid = depositPaid;
            this.AttendingCourse = attendingCourse;
            this.DateBooked = dateBooked;
            this.GuestID = guestID;
        }

        //properties
        public string PodType
        {
            get { return podType; }
            set { podType = value; }
        }

        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public int NoOfOccupants
        {
            get { return noOfOccupants; }
            set { noOfOccupants = value; }
        }

        public int PodID
        {
            get { return podID; }
            set { podID = value; }
        }
        //in the early stages of the development the database recorded true as 'T' and false as 'F'
        //this code converts it back to 'True' and 'False' when a booking object is created
        public string DepositPaid
        {
            get { return depositPaid; }
            set
            {
                if (value == "T")
                {
                    depositPaid = "True";
                }
                else if (value == "F")
                {
                    depositPaid = "False";
                }
                else
                {
                    depositPaid = value;
                }
            }
        }

        public string AttendingCourse
        {
            get { return attendingCourse; }
            set
            {
                if (value == "T")
                {
                    attendingCourse = "True";
                }
                else if (value == "F")
                {
                    attendingCourse = "False";
                }
                else
                {
                    attendingCourse = value;
                }
            }
        }


        public DateTime DateBooked
        {
            get { return dateBooked; }
            set { dateBooked = value; }
        }
        public int GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
      

    }
}