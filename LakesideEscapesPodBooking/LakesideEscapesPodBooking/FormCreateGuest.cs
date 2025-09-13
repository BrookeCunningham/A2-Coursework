using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LakesideEscapesPodBooking
{
    public partial class FormCreateGuest : Form
    {
        List<string> errors = new List<string>();
        int guestID = 0;
        FormMenu menuForm;

        public FormCreateGuest(FormMenu menu)
        {
            InitializeComponent();
            Validation.PopulateComboBoxesGuest(cbGender, cbTitle);
            menuForm = menu;
        }


        public void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                //create an object with these details
                Guest guest = new Guest(cbTitle.Text, txtboxFirstName.Text, txtboxSurname.Text
                    , txtboxEmail.Text, txtboxPhoneNumber.Text, txtboxNotes.Text
                    , txtboxAddress1.Text, txtboxAddress2.Text, txtboxCounty.Text, txtboxCountry.Text,
                    txtboxPostcode.Text, cbGender.Text, dtpDOB.Value);
                //validate data
                errors = Validation.ValidGuest(guest);
                //changes label colours to show errors
                Validation.ChangeLabelGuest(errors, lblTitle, lblFirstName, lblSurname, lblEmail, lblPhoneNumber, lblGender,
                    lblAddress1, lblAddress2, lblCounty, lblCountry, lblPostcode, lblDOB);
                //if no problems with data, add to database
                if (errors.Count == 0)
                {
                    //returns guestID when it adds to the database
                    guestID = tblGuestDAL.AddGuest(guest);
                    //closes this form
                    this.Close();
                    //opens new form and displays GuestID
                    FormShowDetails frm = new FormShowDetails();
                    menuForm.btnCreateGuest.BackColor = Color.WhiteSmoke;
                    frm.lblShow.Text = "Guest ID : " + Convert.ToString(guestID);
                    frm.Show();
                }
                //clears the list
                errors.Clear();
                //sets guest object to null
                guest = null;

            }catch(SqlException)
            {
                MessageBox.Show("There was a problem connection to the database");
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error: \n" + ex.Message);
            }
        }
   
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.btnCreateGuest.BackColor = Color.WhiteSmoke;
        }

      
    }
}
