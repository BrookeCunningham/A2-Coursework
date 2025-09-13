using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.InteropServices.ComTypes;
using System.Drawing;
using System.Windows.Forms;

namespace LakesideEscapesPodBooking
{
    internal class Validation
    {
        //list of errors
        static List<string> errors = new List<string>();
        static string emailPattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";

        //returns a list of the errors for the guest object
        public static List<string> ValidGuest(Guest guestObject)
        {
                //Makes sure the varaibles that are text have no numbers
                if (guestObject.FirstName.Any(Char.IsDigit) || guestObject.FirstName.Length > 20 ||
                    String.IsNullOrEmpty(guestObject.FirstName))
                {
                    errors.Add("FirstName");
                }
                if (guestObject.Surname.Any(Char.IsDigit) || guestObject.Surname.Length > 30
                    || String.IsNullOrEmpty(guestObject.Surname))
                {
                    errors.Add("Surname");
                }
                if (guestObject.County.Any(Char.IsDigit) || guestObject.County.Length > 25 ||
                    String.IsNullOrEmpty(guestObject.County))
                {
                    errors.Add("County");
                }
                if (guestObject.Country.Any(Char.IsDigit) || guestObject.Country.Length > 30 ||
                    String.IsNullOrEmpty(guestObject.Country))
                {
                    errors.Add("Country");
                }
                //valid combo box options
                if (!Guest.genders.Contains(guestObject.Gender))
                {
                    errors.Add("Gender");
                }
                if (!Guest.titles.Contains(guestObject.Title))
                {
                    errors.Add("Title");
                }
                //valid phone number
                if (!IsValidPhoneNumber(guestObject.PhoneNumber) || String.IsNullOrEmpty(guestObject.PhoneNumber))
                {
                    errors.Add("PhoneNumber");
                }
                //valid email
                if (!Regex.IsMatch(guestObject.Email, emailPattern) || String.IsNullOrEmpty(guestObject.Email))
                {
                    errors.Add("Email");
                }
                if (guestObject.Address1.Length > 40 || String.IsNullOrEmpty(guestObject.Address1))
                {
                    errors.Add("Address1");
                }
                if (guestObject.Address2.Length > 40 || String.IsNullOrEmpty(guestObject.Address2))
                {
                    errors.Add("Address2");
                }
                if (guestObject.Postcode.Length < 6 || guestObject.Postcode.Length > 9 ||
                    String.IsNullOrEmpty(guestObject.Postcode))
                {
                    errors.Add("Postcode");
                }
                if (guestObject.DateOfBirth >= DateTime.Now.AddYears(-18))
                {
                    errors.Add("DOB");
                }
 
            //returns a list of all the errors
            return errors;      
        }
        
        //validates the phone Number
        public static bool IsValidPhoneNumber(string number)
        {
            string newNumber = number.Replace(" ", "");

            if (newNumber.Length <= 10 || newNumber.Length >= 12)
            {
                return false;
            }

            foreach (char c in newNumber)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        //changes labels to display errors in guest forms
        public static void ChangeLabelGuest(List<string> errors, Label title, Label firstName, Label surname, Label email
           , Label phoneNumber, Label gender, Label address1, Label address2, Label county, Label country, Label postcode, Label dob)
        {
            if (errors.Contains("Title"))
            {
                title.ForeColor = Color.Red;
            }
            else
            {
                title.ForeColor = Color.White;
            }
            if (errors.Contains("FirstName"))
            {
                firstName.ForeColor = Color.Red;
            }
            else
            {
                firstName.ForeColor = Color.White;
            }
            if (errors.Contains("Surname"))
            {
                surname.ForeColor = Color.Red;
            }
            else
            {
                surname.ForeColor = Color.White;
            }
            if (errors.Contains("Email"))
            {
                email.ForeColor = Color.Red;
            }
            else
            {
                email.ForeColor = Color.White;
            }
            if (errors.Contains("PhoneNumber"))
            {
                phoneNumber.ForeColor = Color.Red;
            }
            else
            {
                phoneNumber.ForeColor = Color.White;
            }
            if (errors.Contains("Gender"))
            {
                gender.ForeColor = Color.Red;
            }
            else
            {
                gender.ForeColor = Color.White;
            }
            if (errors.Contains("Address1"))
            {
                address1.ForeColor = Color.Red;
            }
            else
            {
                address1.ForeColor = Color.White;
            }
            if (errors.Contains("Address2"))
            {
                address2.ForeColor = Color.Red;
            }
            else
            {
                address2.ForeColor = Color.White;
            }
            if (errors.Contains("County"))
            {
                county.ForeColor = Color.Red;
            }
            else
            {
                county.ForeColor = Color.White;
            }
            if (errors.Contains("Country"))
            {
                country.ForeColor = Color.Red;
            }
            else
            {
                country.ForeColor = Color.White;
            }
            if (errors.Contains("Postcode"))
            {
                postcode.ForeColor = Color.Red;
            }
            else
            {
                postcode.ForeColor = Color.White;
            }
            if (errors.Contains("DOB"))
            {
                dob.ForeColor = Color.Red;
            }
            else
            {
                dob.ForeColor = Color.White;
            }

        }

        //populates the comboboxes in Guest Forms
        public static void PopulateComboBoxesGuest(ComboBox cbGender, ComboBox cbTitle)
        {
            foreach (var item in Guest.titles)
            {
                cbTitle.Items.Add(item);
            }
            foreach (var item in Guest.genders)
            {
                cbGender.Items.Add(item);
            }
        }

        //populates comboboxes in Booking Forms
         public static void PopulateComboBoxesBooking(ComboBox cbCourse,
            ComboBox cbDeposit, ComboBox cbPodType)
         {
            foreach (var item in Booking.podTypes)
            {
                cbPodType.Items.Add(item);
            }
            foreach (var item in Booking.trueOrfalse)
            {
                cbDeposit.Items.Add(item);
                cbCourse.Items.Add(item);
            }
        }

        //validates the booking object for complex requirements
        public static List<string> ValidBooking(Booking booking, string podType)
        {
            List<string> errors = new List<string>();
            //duration of stay
            TimeSpan duration = (booking.EndDate.Date.AddDays(1) - booking.StartDate.Date) ;
            // Check if the start date or end date falls within 20th Dec and 20th Jan
            if (booking.StartDate.Month == 12 && booking.StartDate.Day >= 20 || booking.StartDate.Month == 1 && booking.StartDate.Day <= 20 || booking.EndDate.Month == 12 && booking.EndDate.Day >= 20 ||
                booking.StartDate.Month == 1 && booking.StartDate.Day <= 20)
                {
                 errors.Add("You cannot make bookings between the 20th \nof December and the 20th of January.");
                }
                //if the booking is not made two months before the start of the bookinh
                if (booking.StartDate  <= booking.DateBooked.AddMonths(2))
                {
                    errors.Add("You must book two months in advance\n");
                }
                if (duration.TotalDays != 3 && duration.TotalDays != 5 && duration.TotalDays != 7
                    && duration.TotalDays != 14)
                {
                    errors.Add("This is an Invalid duration\n");
                }
            
            
            //If pod Occupancy is correct
            if (podType == "Standard")
            {
                if (booking.NoOfOccupants > 4)
                {
                    errors.Add("Max Occupancy for a standard pod is 4\n");
                }
            }
            else
            {
                if (booking.NoOfOccupants > 6)
                {
                    errors.Add("Max Occupancy for a luxury pod is 6\n");
                }
            }

            return errors;
        }

        //basic validation to enusre correct data type
        //so problem data can be identified before entered into object and exception is thrown
        public static List<string> CorrectDataTypeBooking(TextBox guestID, TextBox occupants, ComboBox cbCourse,
            ComboBox cbDeposit, ComboBox cbPodType)
        {
            List <string> errors = new List<string>();
            DateTime now = DateTime.Now.Date;
            if(string.IsNullOrEmpty(guestID.Text))
            {
                errors.Add("Guest ID");
            }
            
            
            else if (int.TryParse(guestID.Text, out _) == false)
            {
                    errors.Add("Guest ID");
            }
 
            if(string.IsNullOrEmpty(occupants.Text))
            {
                errors.Add("Number Of Occupants");
            }
            else if(int.TryParse(occupants.Text, out _) == false)
            {
                errors.Add("Number Of Occupants");
            }
            if(!Booking.trueOrfalse.Contains(cbDeposit.Text))
            {
                errors.Add("Deposit Paid");
            }
            if (!Booking.trueOrfalse.Contains(cbCourse.Text))
            {
                errors.Add("Attending Course");
            }
            if(!Booking.podTypes.Contains(cbPodType.Text))
            {
                errors.Add("Pod Type");
            }
 
            return errors;
        }

    }
}
