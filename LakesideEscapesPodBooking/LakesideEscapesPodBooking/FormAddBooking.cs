using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakesideEscapesPodBooking
{
    public partial class FormAddBooking : Form
    {
        
        FormMenu menuForm;
        
        public FormAddBooking(FormMenu menu)
        {
            InitializeComponent();
            //populates the combo boxes
            Validation.PopulateComboBoxesBooking(cbCourse,cbDeposit,cbPodType);
            menuForm = menu;

        }

        public void btnCheck_Click(object sender, EventArgs e)
        {
            try {
                // Declaring variables
                bool validGuest = true;
                lblError.Text = String.Empty;
                List<int> pods = new List<int>();
                pods.Clear();
                List<int> podsOfType = new List<int>();
                podsOfType.Clear();
                // Checks if there are any invalid types to avoid wrong data type going into object and throwing exception
                List<string> typeErrors = Validation.CorrectDataTypeBooking(txtboxGuestID, txtboxOccupants, cbCourse, cbDeposit, cbPodType);

                // If there are type errors, display to user
                if (typeErrors.Count != 0)
                {
                    lblError.Text = "Please enter valid values for ";
                    foreach (string error in typeErrors)
                    {
                        lblError.Text += "\n" + error;
                    }
                    lblError.Visible = true;
                }
                // If not, carry on more complex checks
                else
                {
                    // Checks if there is a guest with that ID
                    Guest tempGuest = tblGuestDAL.ReturnGuest(Convert.ToInt32(txtboxGuestID.Text));

                    if (tempGuest == null)
                    {
                        lblError.Text = "This is an invalid GuestID\n";
                        lblError.Visible = true;
                        validGuest = false;
                    }


                    // Creates a booking object with the provided data
                    Booking booking = new Booking(dtPStart.Value, dtPend.Value, Convert.ToInt32(txtboxOccupants.Text), 0, cbDeposit.Text, cbCourse.Text, DateTime.Now.Date, Convert.ToInt32(txtboxGuestID.Text));

                    // Receives pods of the type required
                    podsOfType = tblPodDAL.ReturnReleventPodIDs(cbPodType.Text);

                    // Passes the list through to the method which gives the booking a podID
                    pods = tblBookingDAL.ReturnsVacentPodIDs(booking.StartDate, booking.EndDate, podsOfType);

                    bool validCourse = tblCourseGuestsDAL.DoCourseDatesOverlapWithBooking(booking);

                    //Checks if they have a course booked
                    if (booking.AttendingCourse == "True")
                    {
                        if (validCourse == false)
                        {
                            lblError.Visible = true;
                            lblError.Text += "There is no course booked for these dates\n";
                        }
                    }
                    else
                    {                        
                        validCourse = true;
                    }
                    if (pods.Count != 0)
                    {
                        booking.PodID = pods[0];
                        // String of logicErrors from booking object
                        List<string> logicErrors = Validation.ValidBooking(booking, cbPodType.Text);

                        // If there are no logic errors add booking and display details
                        if (logicErrors.Count == 0 && validGuest == true && validCourse == true)
                        {
                            booking.BookingID = tblBookingDAL.addBooking(booking);
                            tblBookingDAL.ApplyDiscounts(booking);                                                       
                            //shows details
                            FormShowDetails frmShow = new FormShowDetails();
                            this.Close();
                            menuForm.btnAddBooking.BackColor = Color.WhiteSmoke;
                            frmShow.Show();
                            frmShow.lblShow.Text = "Booking ID : " + booking.BookingID + "\nPod ID : " + booking.PodID;

                        }
                        // Display logic errors
                        else
                        {
                            foreach (string logicError in logicErrors)
                            {
                                lblError.Visible = true;
                                lblError.Text += logicError;
                            }
                        }
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "There are no pods avaliable for these dates";
                    }
                }
        }catch(SqlException)
            {
                MessageBox.Show("There was an error connecting to the database");
            }          
            catch(Exception ex)
            {
                //catches any exceptions
                MessageBox.Show("Sorry, there was an error\n" + ex.Message);                      
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menuForm.btnAddBooking.BackColor = Color.WhiteSmoke;
            this.Close();
        }

        private void lblOccupants_Click(object sender, EventArgs e)
        {

        }
    }
}
