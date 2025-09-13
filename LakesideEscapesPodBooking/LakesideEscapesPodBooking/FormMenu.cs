using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakesideEscapesPodBooking
{
    public partial class FormMenu : Form
    {
        private Form activeForm = null;

        public FormMenu()
        {
            InitializeComponent();
            hidePanels();
            //called everytime the program opens
            tblBookingDAL.DeleteBookingsWithDepositNotPaid();
        }

        //opens the new form within this form
        private void openForm(Form requiredForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = requiredForm;
            requiredForm.TopLevel = false;
            requiredForm.FormBorderStyle = FormBorderStyle.None;
            requiredForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(requiredForm);
            pnlContainer.Tag = requiredForm;
            requiredForm.BringToFront();
            requiredForm.Show();
        }

        //add customer
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            openForm(new FormCreateGuest(this));
            btnCreateGuest.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            btnViewGuest.BackColor = System.Drawing.Color.WhiteSmoke;
            btnEditGuest.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        //add booking
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            openForm(new FormAddBooking(this));
            btnAddBooking.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            btnCreateGuest.BackColor = System.Drawing.Color.WhiteSmoke;
            btnViewBooking.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        //on exit clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //view booking
        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            openForm(new FormViewBookings(this));
            btnViewBooking.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            btnAddBooking.BackColor = System.Drawing.Color.WhiteSmoke;
            btnEditBooking.BackColor = System.Drawing.Color.WhiteSmoke;
        }
        private void btnGuest_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlGuest);
        }
        private void hidePanels()
        {
            pnlGuest.Visible = false;
            pnlBooking.Visible = false;
            pnlPods.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidePanels();
                subMenu.Visible = true;
            }
             else
                subMenu.Visible = false;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlBooking);
        }
        //view guest
        private void btnViewGuest_Click(object sender, EventArgs e)
        {
            openForm(new FormViewGuest(this));
            btnViewGuest.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            btnCreateGuest.BackColor = System.Drawing.Color.WhiteSmoke;
            btnEditGuest.BackColor = System.Drawing.Color.WhiteSmoke;
        }
        //edit guest
        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            openForm(new FormEditGuest(this));
            btnEditGuest.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            btnViewGuest.BackColor = System.Drawing.Color.WhiteSmoke;
            btnCreateGuest.BackColor = System.Drawing.Color.WhiteSmoke;
        }
        //edit booking
        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            openForm(new FormEditBooking(this));
            btnEditBooking.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            btnAddBooking.BackColor = System.Drawing.Color.WhiteSmoke;
            btnViewBooking.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void btnPods_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlPods);
        }


        private void btnEditPod_Click(object sender, EventArgs e)
        {
            openForm(new FormEditPod(this));
            btnViewPod.BackColor = System.Drawing.Color.WhiteSmoke;
            btnEditPod.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void btnViewPod_Click(object sender, EventArgs e)
        {
            openForm(new FormViewPod(this));
            btnViewPod.BackColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0");
            btnEditPod.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            hidePanels();
            openForm(new FormReport());          
        }
    }
}
