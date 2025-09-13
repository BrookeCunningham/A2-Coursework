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
    public partial class FormViewPod : Form
    {
        FormMenu frm;
        public FormViewPod(FormMenu frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnAddPod_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                //populate the datagrid view with the podID, type and details of type
                tblPodDAL.PopulateDGVGivenPod(Convert.ToInt32(cbPodID.Text), dgvAllPod);
                if (dgvAllPod.Rows.Count > 1)
                {
                    dgvPodDescription.Visible = false;
                    dgvPod.Visible = false;
                    dgvAllPod.Columns[3].Width = 150;
                    dgvAllPod.Columns[2].Width = 300;
                    dgvAllPod.Visible = true;
                    dgvAllPod.Columns[0].HeaderText = "Pod ID";
                    dgvAllPod.Columns[1].HeaderText = "Pod Type";
                    dgvAllPod.Columns[2].HeaderText = "Pod Description";
                    dgvAllPod.Columns[3].HeaderText = "Pod Cost Per Person Per Night";
                    dgvAllPod.Columns[4].HeaderText = "Maximum Occupancy";
                }
                else
                {
                    dgvPodDescription.Visible = true;
                    dgvAllPod.Visible = false;
                    dgvPod.Visible = true;
                    lblError.Visible = true;
                    lblError.Text = "This is an invalid Pod ID";
                }

            }catch(SqlException)
            {
                MessageBox.Show("There was an error connecting to the database");
            }
            catch(FormatException)
            {
                lblError.Visible = true;
                lblError.Text = "Please insert a numerical value for Pod ID";
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);                       
            }
        }

        private void FormViewPod_Load(object sender, EventArgs e)
        {
            //fill the tables on form load
            this.tblPodDescriptionTableAdapter.Fill(this.tblPodDescriptionDataSet.tblPodDescription);
            this.tblPodTableAdapter.Fill(this.viewTblPodDataSet.tblPod);
            //populates combobox with all the podIDs
            foreach (string id in tblPodDAL.GetAllPodIds())
            {
                cbPodID.Items.Add(id);
            }
            dgvPodDescription.Columns[1].Width = 200;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvAllPod.Visible = false;
            dgvPod.Visible = true;
            dgvPodDescription.Visible = true;
            cbPodID.Text = string.Empty;
            lblError.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.btnViewPod.BackColor = Color.WhiteSmoke;
        }

    }
}