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
    public partial class FormAddPod : Form
    {
        FormMenu menuFrm;
        int podID;
        public FormAddPod(FormMenu frm)
        {
            InitializeComponent();
            this.menuFrm = frm;
        }

        private void btnAddPod_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (!String.IsNullOrEmpty(cbType.Text))
            {
                if(Booking.podTypes.Contains(cbType.Text))
                {
                    Pod pod = new Pod(cbType.Text);
                    podID = tblPodDAL.AddPod(pod);
                    this.Close();
                    menuFrm.btnAddPod.BackColor = Color.WhiteSmoke;
                    FormShowDetails frmShow = new FormShowDetails();
                    frmShow.lblShow.Text = "Success!\nPodID : " + podID;
                    frmShow.Show();
                    
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Please enter a valid Pod Type";
                }               
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Please enter a Pod Type";
            }
  
        }

        private void FormAddPod_Load(object sender, EventArgs e)
        {
            foreach(string type in Booking.podTypes)
            {
                cbType.Items.Add(type);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menuFrm.btnAddPod.BackColor = Color.WhiteSmoke;
            this.Close();
        }
    }
}
