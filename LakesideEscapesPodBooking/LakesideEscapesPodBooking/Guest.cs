using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakesideEscapesPodBooking
{
    internal class Guest
    {
        // Declaring lists for comboboxes
        public static List<string> titles = new List<string>() { "Mr", "Mrs", "Ms", "Miss" };
        public static List<string> genders = new List<string>() { "Male", "Female" };
        //variables
        protected int guestID;
        protected string title;
        protected string firstName;
        protected string surname;
        protected string email;
        protected string phoneNumber;
        protected string notes;
        protected string address1;
        protected string address2;
        protected string county;
        protected string country;
        protected string postcode;
        protected string gender;
        protected DateTime dateOfBirth;
        //contructor
        public Guest(string title, string firstName, string surname, string email, string phoneNumber, string notes, string address1, string address2, string county, string country, string postcode, string gender, DateTime dateOfBirth)
        {
            this.Title = title;
            this.FirstName = firstName;
            this.Surname = surname;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Notes = notes;
            this.Address1 = address1;
            this.Address2 = address2;
            this.County = county;
            this.Country = country;
            this.Postcode = postcode;
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
        }
        //constructors
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public int GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        public string County
        {
            get { return county; }
            set { county = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
    }

}
