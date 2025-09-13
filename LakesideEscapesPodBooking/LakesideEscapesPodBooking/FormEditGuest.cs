using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakesideEscapesPodBooking
{
    public partial class FormEditGuest: Form
    {
        FormMenu menuForm;
        Guest tempGuest;
        List<string> errors = new List<string> ();
        public FormEditGuest(FormMenu menuForm)
        {
            InitializeComponent();
            this.menuForm = menuForm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.btnEditGuest.BackColor = Color.WhiteSmoke;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            lblError.ForeColor = Color.Red;

            if (int.TryParse(txtboxGuestID.Text, out _))
            {
                VisibilityGuest(false);
      
                try
                {
                    //returns a guest object by GuestID
                    tempGuest = tblGuestDAL.ReturnGuest(Convert.ToInt32(txtboxGuestID.Text));
                    //if GuestID is valid
                    if (tempGuest != null)
                    {
                        tempGuest.GuestID = Convert.ToInt32(txtboxGuestID.Text);
                        //populate textboxes with guest data
                        //populates comboboxes with options
                        Validation.PopulateComboBoxesGuest(cbGender, cbTitle);
                        VisibilityGuest(true);
                        PopulateItemsWithGuest();

                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "This is an invalid Guest ID";
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
            }else
            {
                lblError.Text = "GuestID should be numeric";
                lblError.Visible= true;
                VisibilityGuest(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            errors.Clear();
            //updates the object to the changed fields
            try
            {
                if (EditGuestObject())
                {
                    lblError.Visible = false;
                    //validates the new object
                    errors = Validation.ValidGuest(tempGuest);
                    //Highlights any errors
                    Validation.ChangeLabelGuest(errors, lblTitle, lblFirstName, lblSurname, lblEmail, lblPhoneNumber, lblGender,
                        lblAddress1, lblAddress2, lblCounty, lblCountry, lblPostcode, lblDOB);
                    //if object is valid, update it in the database
                    if (errors.Count == 0)
                    {
                        //update the guest
                        tblGuestDAL.UpdateGuest(tempGuest);
                        txtboxGuestID.Text = string.Empty;
                        VisibilityGuest(false);
                        lblError.ForeColor = Color.White;
                        lblError.Visible = true;
                        lblError.Text = "Success!";
                    }
                }else
                {
                    lblError.Visible = true;
                    lblError.Text = "Please enter values for every field";
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
    
        //changes the visibility of the elements
        private void VisibilityGuest(bool show)
        {
            if(show)
            {
                lblTitle.Visible = true;
                lblFirstName.Visible = true;
                lblSurname.Visible = true;
                lblEmail.Visible = true;
                lblCounty.Visible = true;
                lblCountry.Visible = true;
                lblAddress1.Visible = true;
                lblAddress2.Visible = true;
                lblGender.Visible = true;
                lblNotes.Visible= true;
                lblPhoneNumber.Visible = true;
                lblPostcode.Visible = true;
                cbTitle.Visible = true;
                cbGender.Visible = true;
                txtboxFirstName.Visible = true;
                txtboxSurname.Visible = true;
                txtboxEmail.Visible = true;
                txtboxPhoneNumber.Visible = true;
                txtboxEmail.Visible = true;
                txtboxPhoneNumber.Visible = true;
                txtboxPostcode.Visible = true;
                txtboxAddress1.Visible = true;
                txtboxAddress2.Visible = true;
                txtboxPostcode.Visible = true;
                txtboxCounty.Visible=true;
                txtboxCountry.Visible=true;
                txtboxNotes.Visible=true;
                btnEdit.Visible = true;
                btnClear.Visible = true;
                lblDOB.Visible = true;
                dtpDOB.Visible=true;
            }
            else
            {
                lblTitle.Visible = false;
                lblFirstName.Visible = false;
                lblSurname.Visible = false;
                lblCounty.Visible = false;
                lblEmail.Visible = false;
                lblCountry.Visible = false;
                lblAddress1.Visible = false;
                lblAddress2.Visible = false;
                lblGender.Visible = false;
                lblNotes.Visible = false;
                lblPhoneNumber.Visible = false;
                lblPostcode.Visible = false;
                cbTitle.Visible = false;
                cbGender.Visible = false;
                txtboxFirstName.Visible = false;
                txtboxSurname.Visible = false;
                txtboxEmail.Visible = false;
                txtboxPhoneNumber.Visible = false;
                txtboxEmail.Visible = false;
                txtboxPhoneNumber.Visible = false;
                txtboxPostcode.Visible = false;
                txtboxAddress1.Visible = false;
                txtboxAddress2.Visible = false;
                txtboxPostcode.Visible = false;
                txtboxCounty.Visible = false;
                txtboxCountry.Visible = false;
                txtboxNotes.Visible = false;
                btnEdit.Visible = false;
                btnClear.Visible = false;
                lblDOB.Visible = false;
                dtpDOB.Visible = false;

            }
        }

        //updates the guest object with the input values
        private bool EditGuestObject()
        {          
            if(!String.IsNullOrEmpty(cbTitle.Text))
            {
                tempGuest.Title = cbTitle.Text;
            }
            else
            {
                return false;
            }
            if (!String.IsNullOrEmpty(txtboxFirstName.Text))
            {
                tempGuest.FirstName = txtboxFirstName.Text;
            }
            else
            {
                return false;
            }
            if (!String.IsNullOrEmpty(txtboxSurname.Text))
            {
                tempGuest.Surname = txtboxSurname.Text;
            }
            else
            {
                return false;
            }
            if (!String.IsNullOrEmpty(txtboxPhoneNumber.Text))
            {
                tempGuest.PhoneNumber = txtboxPhoneNumber.Text;
            }
            else
            {
                return false;
            }
            if (!String.IsNullOrEmpty(txtboxEmail.Text))
            {
                tempGuest.Email = txtboxEmail.Text;
            }
            else
            {
                return false;
            }
            if (!String.IsNullOrEmpty(txtboxAddress1.Text))
            {
                tempGuest.Address1 = txtboxAddress1.Text;
            }
            else
            {
                return false;
            }
            if (!String.IsNullOrEmpty(txtboxAddress2.Text))
            {
                tempGuest.Address2 = txtboxAddress2.Text;
            }
            else
            {
                return false;
            }
            if (!String.IsNullOrEmpty(txtboxCountry.Text))
            {
                tempGuest.Country = txtboxCountry.Text;
            }
            else
            {
                return false;
            }
            if (!String.IsNullOrEmpty(txtboxCounty.Text))
            {
                tempGuest.Country = txtboxCounty.Text;
            }
            else
            {
                return false;
            }
            if (!String.IsNullOrEmpty(txtboxPostcode.Text))
            {
                tempGuest.Postcode = txtboxPostcode.Text;
            }
            else
            {
                return false;
            }
            tempGuest.Notes = txtboxNotes.Text;
            tempGuest.DateOfBirth = dtpDOB.Value;

            return true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            VisibilityGuest(false);
            txtboxGuestID.Text = string.Empty;
        }

        //populates the elements with the correct guest details
        private void PopulateItemsWithGuest()
        {
            cbTitle.Text = tempGuest.Title;
            txtboxFirstName.Text = tempGuest.FirstName;
            txtboxSurname.Text = tempGuest.Surname;
            txtboxEmail.Text = tempGuest.Email;
            txtboxPhoneNumber.Text = tempGuest.PhoneNumber;
            txtboxCounty.Text = tempGuest.County;
            txtboxCountry.Text = tempGuest.Country;
            txtboxAddress1.Text = tempGuest.Address1;
            txtboxAddress2.Text = tempGuest.Address2;
            txtboxPostcode.Text = tempGuest.Postcode;
            cbGender.Text = tempGuest.Gender;
            txtboxNotes.Text = tempGuest.Notes;
            dtpDOB.Value = tempGuest.DateOfBirth;
        }

    }
}
