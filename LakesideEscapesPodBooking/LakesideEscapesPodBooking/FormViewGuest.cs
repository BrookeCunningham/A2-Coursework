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
    public partial class FormViewGuest : Form
    {
        int guestID;
        FormMenu menuForm;
        public FormViewGuest(FormMenu menu)
        {
            InitializeComponent();
            this.menuForm = menu;
            btnGuestID_Click(this, EventArgs.Empty);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.btnViewGuest.BackColor = Color.WhiteSmoke;
        }

        private void btnGuestID_Click(object sender, EventArgs e)
        {
            btnDetails.BackColor = Color.Gainsboro;
            btnGuestID.BackColor = Color.WhiteSmoke;
            pnlGuestID.BringToFront();
            btnGuestID.Width = 350;
            btnDetails.Width = pnlContainer.Width - btnGuestID.Width;
            txtboxPostcode.Text = String.Empty;
            txtboxSurname.Text = String.Empty;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            btnGuestID.BackColor = Color.Gainsboro;
            btnDetails.BackColor = Color.WhiteSmoke;
            pnlDetails.BringToFront();
            btnDetails.Width = 350;
            btnGuestID.Width = pnlContainer.Width - btnDetails.Width;
            txtboxGuestID.Text = String.Empty;
            tblGuestBindingSource.Filter = String.Empty;
            dgvGuest.DataSource = tblGuestBindingSource;
        }


        private void UpdateDataGridView()
        {
            try
            {
                string surname = txtboxSurname.Text;
                string postcode = txtboxPostcode.Text;
                //shows surnames and postcodes that match on textchanged event    
                tblGuestBindingSource.Filter = $"Surname LIKE '{surname}%' AND Postcode LIKE '{postcode}%'";
                dgvGuest.DataSource = tblGuestBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: \n" + ex.Message);
            }
        }

        private void FormViewGuest_Load(object sender, EventArgs e)
        {
            this.tblGuestTableAdapter.Fill(this.tblViewGuestDataSet.tblGuest);
        }

        private void txtboxSurname_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void txtboxPostcode_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                //checks guestID is a int
                if (int.TryParse(txtboxGuestID.Text, out _) == true)
                {
                    //create a guest object
                    int guestID = Convert.ToInt32(txtboxGuestID.Text);

                    if (tblGuestDAL.ReturnGuest(guestID) != null)
                    {
                        //if valid guestID then filter the datagridview
                        lblError.Visible = false;
                        tblGuestBindingSource.Filter = $"GuestID = {guestID}";
                        dgvGuest.DataSource = tblGuestBindingSource;
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "This is an invalid Guest ID";
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Guest ID should be numeric";
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
            txtboxSurname.Text = String.Empty;
            txtboxPostcode.Text = String.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxGuestID.Text = String.Empty;
            lblError.Text = String.Empty;
            tblGuestBindingSource.Filter = String.Empty;
            dgvGuest.DataSource = tblGuestBindingSource;
        }
    }
}