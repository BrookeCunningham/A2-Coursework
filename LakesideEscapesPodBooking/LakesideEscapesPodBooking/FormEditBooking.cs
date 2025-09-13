using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LakesideEscapesPodBooking
{
    public partial class FormEditBooking : Form
    {
        string field;
        List<string> logicErrors = new List<string>();
        bool validCourse = true;
        FormMenu formMenu;
        Booking editBooking;

        public FormEditBooking(FormMenu frm )
        {
            InitializeComponent();
            formMenu = frm;
            btnEditView_Click(this, null);
        }
      
        private void FormEditBooking_Load(object sender, EventArgs e)
        {
            //adds the values to the combobox
            cbField.Items.Add("Date");
            cbField.Items.Add("Number of Occupants");
            cbField.Items.Add("Attending Course");
            cbField.Items.Add("Pod Type");
            cbField.Items.Add("Deposit Payed");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //calls validation method
            ValidateAndEditBooking();
        }     
        private void cbField_TextChanged(object sender, EventArgs e)
        {
            //if date selected then show date time pickers
            if (cbField.Text == "Date")
            {
                dtpValueStart.Visible = true;
                dtpValueEnd.Visible = true;
                lbl2.Visible = true;
                lbl1.Text = "Start Date";
                txtboxValue.Visible = false;
                cbValue.Visible = false;
            }
            //if number of occupants selected show textbox
            else if (cbField.Text == "Number of Occupants")
            {
                lbl1.Text = "Value";
                dtpValueStart.Visible = false;
                txtboxValue.Visible = true;
                cbValue.Visible = false;
                dtpValueEnd.Visible = false;
                lbl2.Visible = false;
                
            }
            //else show combobox and populate accordingly
            else
            { 
                lbl1.Text = "Value";
                dtpValueStart.Visible = false;
                txtboxValue.Visible = false;
                cbValue.Visible = true;
                dtpValueEnd.Visible = false;
                lbl2.Visible = false;
                if (cbField.Text == "Attending Course" || cbField.Text == "Deposit Payed")
                {
                    cbValue.Items.Clear();

                    foreach(string value in Booking.trueOrfalse)
                    {
                        cbValue.Items.Add(value);
                    }
                }
                else
                {
                    cbValue.Items.Clear();

                    foreach (string value in Booking.podTypes)
                    {
                        cbValue.Items.Add(value);
                    }
                }
            }
        }

        private void ValidateAndEditBooking()
        {
            lblError.ForeColor = Color.Red;
            lblError.Visible = false;
            lblError.Text = "";

            try
            {
                //checks if there is an invalid data type
                if (IsInputInvalidDataType())
                {
                    lblError.Visible = true;
                    lblError.Text = "Please enter valid data";
                    return;
                }
                //if not makes a booking object
                editBooking = tblBookingDAL.GetBookingObjectFromID(Convert.ToInt32(txtboxBookingID.Text));
                //if there is no corresponding bookingID it will return null
                if (editBooking == null)
                {
                    lblError.Visible = true;
                    lblError.Text = "This is an invalid Booking ID";
                    return;
                }
                else
                {
                    editBooking.BookingID = Convert.ToInt32(txtboxBookingID.Text);
                    UpdateBooking();
                   

                    //assigns new podID and date range if required
                    if (cbValue.Visible && cbField.Text == "Pod Type")
                    {                    
                        List<int> pods = tblBookingDAL.ReturnsVacentPodIDs(editBooking.StartDate, editBooking.EndDate, tblPodDAL.ReturnReleventPodIDs(cbValue.Text));
                        if (pods.Count > 0)
                        {
                            editBooking.PodID = pods[0];
                            
                            editBooking.PodType = cbValue.Text;
                        }
                        else
                        {
                            lblError.Visible = true;
                            lblError.Text = "There are no pods avaliable for this date range";
                            return;
                        }
                    }else if(cbField.Text == "Date")
                    {
                       
                        List<int> pods = tblBookingDAL.ReturnsVacentPodIDs(editBooking.StartDate, editBooking.EndDate, tblPodDAL.ReturnReleventPodIDs(tblPodDAL.GetPodType(editBooking.PodID)));
                        if (pods.Count > 0)
                        {
                            editBooking.PodID = pods[0];                          
                        }
                        else
                        {
                            lblError.Visible = true;
                            lblError.Text = "There are no pods avaliable for this date range";
                            return;
                        }
                    }
                    
                    
                }
                //sets the objects podType 
                editBooking.PodType = tblPodDAL.GetPodType(editBooking.PodID);
                //validates the booking object
                List<string> logicErrors = Validation.ValidBooking(editBooking, editBooking.PodType);
                //checks if they are on a valid course
                if (cbField.Text == "Attending Course" && cbField.Visible == true)
                {
                    if (editBooking.AttendingCourse == "True")
                    {
                        validCourse = tblCourseGuestsDAL.DoCourseDatesOverlapWithBooking(editBooking);
                    }
                    else
                    {
                        validCourse = true;
                    }
                }
                //if no logic errors and course value is valid
                if (logicErrors.Count == 0 && validCourse == true || (logicErrors.Count == 1 && logicErrors.Contains("You must book two months in advance\n") && validCourse == true))
                {
                    //updates the booking
                    tblBookingDAL.UpdateBooking(editBooking);
                    lblError.ForeColor = Color.Black;
                    lblError.Visible = true;
                    lblError.Text = "This was a successful edit";
                }
                else
                {
                    //show the errors
                    lblError.Visible = true;
                    lblError.Text = string.Join("\n", logicErrors);
                    lblError.Text = lblError.Text.Replace("You must book two months in advance\n", "");
                    if (!validCourse)
                    {
                        lblError.Text += "\nThere is no course booked for these dates";
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("There was a problem connection to the database" + e.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: \n" + ex.Message);
            }
        }

        //checks if all the data types are valid before adding into them into an object to prevent an exception
        private bool IsInputInvalidDataType()
        {
            bool invalid = false;
            lblError.Text = ""; 

            if (String.IsNullOrEmpty(txtboxBookingID.Text))
            {
                lblError.Text += "Please enter a Booking ID\n";
                invalid = true;
            }

            if (String.IsNullOrEmpty(cbField.Text))
            {
                lblError.Text += "Please select a field\n";
                invalid = true;
            }

            if (String.IsNullOrEmpty(txtboxValue.Text) && txtboxValue.Visible == true)
            {
                lblError.Text += "Please enter a value\n";
                invalid = true;
            }

            if (cbField.Text == "Number Of Occupants" && !IsNumeric(txtboxValue.Text))
            {
                lblError.Text += "Please enter a valid number of occupants\n";
                invalid = true;
            }

            if ((cbField.Text == "Attending Course" || cbField.Text == "Deposit Payed") && !Booking.trueOrfalse.Contains(cbValue.Text))
            {
                lblError.Text += "Please enter a valid value for " + cbField.Text + "\n";
                invalid = true;
            }

            if (cbField.Text == "Pod Type" && !Booking.podTypes.Contains(cbValue.Text))
            {
                lblError.Text += "Please enter a valid pod type\n";
                invalid = true;
            }

            return invalid;
        }
        
        bool IsNumeric(string input)
        {
            return input.All(char.IsDigit);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            formMenu.btnEditBooking.BackColor = Color.WhiteSmoke;
        }

        private void UpdateBooking()
        {
            //updates the object created using the bookingID with the data input
            if (cbField.Text == "Date")
            {
                editBooking.StartDate = dtpValueStart.Value;
                editBooking.EndDate = dtpValueEnd.Value;
            }
            else if (cbField.Text == "Number of Occupants")
            {
                editBooking.NoOfOccupants = Convert.ToInt32(txtboxValue.Text);
            }
            else if(cbField.Text == "Attending Course")
            {
                editBooking.AttendingCourse = cbValue.Text;
            }
            else if( cbField.Text == "Pod Type")
            {
                editBooking.PodType = cbValue.Text;
            }
            else if(cbField.Text == "Deposit Payed")
            {
                editBooking.DepositPaid = cbValue.Text;
            }
            editBooking.DateBooked = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears the input fields
            txtboxBookingID.Text = string.Empty;
            cbField.Text = string.Empty;
            cbValue.Text = string.Empty;
            txtboxValue.Text = string.Empty;
            dtpValueStart.Value = DateTime.Now;
            dtpValueEnd.Value = DateTime.Now;
            lblError.Text = string.Empty;
        }

     
        private void btnEditView_Click(object sender, EventArgs e)
        {
            //button GUI control
            pnlEdit.Visible = true;
            pnlDelete.Visible = false;
            btnEditView.BackColor = Color.WhiteSmoke;
            btnDeleteShow.BackColor = Color.Gainsboro;    
            btnEditView.Width = 300; 
            btnDeleteShow.Width = pnlEdit.Width - btnEditView.Width; 
        }

        private void btnDeleteShow_Click(object sender, EventArgs e)
        {
            //button GUI control
            pnlEdit.Visible = false;
            pnlDelete.Visible = true;
            btnDeleteShow.BackColor = Color.WhiteSmoke;
            btnEditView.BackColor = Color.Gainsboro;
            dtpValueStart.Value = DateTime.Now;
            dtpValueEnd.Value = DateTime.Now;          
            btnDeleteShow.Width = 300; 
            btnEditView.Width = pnlEdit.Width - btnDeleteShow.Width; 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int bookingID = Convert.ToInt32(txtboxBookingID2.Text);
                lblErrorDelete.Visible = false;
                //makes a booking object using ID
                Booking deleteBooking = tblBookingDAL.GetBookingObjectFromID(bookingID);
                //checks if returns null (no bookingID found)
                if (deleteBooking != null)
                {
                    //deletes the booking
                    tblBookingDAL.DeleteBooking(bookingID);
                    lblErrorDelete.Visible = true;
                    lblErrorDelete.ForeColor = Color.Black;
                    lblErrorDelete.Text = "This booking was deleted";
                }
                else
                {
                    //error is shown to user
                    lblErrorDelete.Visible = true;
                    lblErrorDelete.ForeColor = Color.Red;
                    lblErrorDelete.Text = "This is an invalid BookingID";
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("There was a problem connection to the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: \n" + ex.Message);
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtboxBookingID2.Text = String.Empty;
            lblErrorDelete.Visible = false;
        }

    }
}
