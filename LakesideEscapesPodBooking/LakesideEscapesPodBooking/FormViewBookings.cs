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
    public partial class FormViewBookings : Form
    {
        FormMenu menuForm;
        public FormViewBookings(FormMenu menu)
        {
            InitializeComponent();
            menuForm = menu;
            btnBookingID_Click(this, EventArgs.Empty);
        }


        private void btnBookingID_Click(object sender, EventArgs e)
        {
            //code to switch to bookingID panel
            btnDetails.BackColor = Color.Gainsboro;
            btnBookingID.BackColor = Color.WhiteSmoke;
            pnlBookingID.BringToFront();
            btnBookingID.Width = 350;
            btnDetails.Width = pnlContainer.Width - btnBookingID.Width;
            txtboxPodID.Text = String.Empty;
            txtboxPodID.Text = String.Empty;
            tblBookingBindingSource.Filter = null;
            dgvBooking.DataSource = tblBookingBindingSource;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //code to switch to guest details panel
            btnBookingID.BackColor = Color.Gainsboro;
            btnDetails.BackColor = Color.WhiteSmoke;
            pnlDetails.BringToFront();
            btnDetails.Width = 350;
            btnBookingID.Width = pnlContainer.Width - btnBookingID.Width;
            txtboxBookingID.Text = String.Empty;
            tblBookingBindingSource.Filter = String.Empty;
            dgvBooking.DataSource = tblBookingBindingSource;
        }

        private void FormViewBookings_Load(object sender, EventArgs e)
        {
            this.tblBookingTableAdapter.Fill(this.tblBookingDataSet.tblBooking);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //checks if it is a valid bookingID
                int bookingID = Convert.ToInt32(txtboxBookingID.Text);
                Booking booking = tblBookingDAL.GetBookingObjectFromID(bookingID);
                //if a valid booking then filter datagridview
                if (booking != null)
                {
                    lblError.Visible = false;
                    tblBookingBindingSource.Filter = $"BookingID = {bookingID}";
                    dgvBooking.DataSource = tblBookingBindingSource;

                }
                else
                {
                    //if not inform user
                    lblError.Text = "This is an invalid Booking ID";
                    lblError.Visible = true;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("There was a problem connection to the database");
            }
            catch (System.FormatException)
            {
                lblError.Text = "Please enter a numerical value for Booking ID";
                lblError.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: \n" + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxBookingID.Text = string.Empty;
            tblBookingBindingSource.Filter = null;
            dgvBooking.DataSource = tblBookingBindingSource;
        }    
        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            try
            {
                //when they search a PodID and dates
                if (!String.IsNullOrEmpty(txtboxPodID.Text))
                {
                    lblErrorPodID.Visible = false;
                    int podID = Convert.ToInt32(txtboxPodID.Text);
                    string startString = dtpStart.Value.ToString("MM/dd/yyyy");
                    string endString = dtpEnd.Value.ToString("MM/dd/yyyy");
                    //show all bookings with the same pod ID and within the given dates
                    tblBookingBindingSource.Filter = $"PodID = {podID} AND BookingStartDate >= #{startString}# AND BookingEndDate <= #{endString}#";
                    dgvBooking.DataSource = tblBookingBindingSource;
                }
                else
                {
                    //shown if an invalid PodID is shown
                    lblErrorPodID.Visible = true;
                    lblErrorPodID.Text = "Please enter a PodID";
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("There was a problem connection to the database");
            }
            catch (FormatException)
            {
                lblErrorPodID.Visible = true;
                lblErrorPodID.Text = "Please enter a numerical value for Pod ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: \n" + ex.Message);
            }

        }
        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtboxPodID.Text = string.Empty;
            tblBookingBindingSource.Filter = null;
            dgvBooking.DataSource = tblBookingBindingSource;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            lblErrorPodID.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menuForm.btnViewBooking.BackColor = Color.WhiteSmoke;
            this.Close();
        }
    }
}
