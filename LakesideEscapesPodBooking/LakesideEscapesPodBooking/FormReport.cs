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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            this.reportViewer.RefreshReport();
            cbSelect.Items.Add("Organise Report By Most Popular Pods");
            cbSelect.Items.Add("Organise Report By Most Frequent Guests");
            cbSelect.Items.Add("Organise Report By Rate Of Bookings");
            cbSelect.Items.Add("Organise Report By Course Guests");
        }

        private void btnOrganisePods_Click(object sender, EventArgs e)
        {
            try
            {
                cbSelect.ForeColor = Color.Black;

                if (cbSelect.Text == (string)cbSelect.Items[0])
                {
                    reportViewer.LocalReport.ReportPath = null;
                    reportViewer.Visible = true;
                    tblPodDAL.UpdateReportByFrequencyOfPodIDs(reportViewer);
                }
                else if (cbSelect.Text == (string)cbSelect.Items[1])
                {
                    reportViewer.LocalReport.ReportPath = null;
                    reportViewer.Visible = true;
                    tblGuestDAL.UpdateReportByFrequencyOfGuestIDs(reportViewer);
                }
                else if (cbSelect.Text == (string)cbSelect.Items[2])
                {
                    reportViewer.LocalReport.ReportPath = null;
                    reportViewer.Visible = true;
                    tblBookingDAL.LoadBookingGraphReport(reportViewer);
                }
                else if (cbSelect.Text == (string)cbSelect.Items[3])
                {
                    reportViewer.LocalReport.ReportPath = null;
                    reportViewer.Visible = true;
                    tblCourseGuestsDAL.UpdateReportByCourseGuestsDetails(reportViewer);
                }
                else
                {
                    reportViewer.Visible = true;
                }
                
            }catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }


        }
    }
}
