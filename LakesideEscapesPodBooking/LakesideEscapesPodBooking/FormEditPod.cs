using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakesideEscapesPodBooking
{
    public partial class FormEditPod : Form
    {
        FormMenu frm;
        bool updatedPod;
        PodDescription podDes;
        public FormEditPod(FormMenu frm)
        {
            InitializeComponent();
            this.frm = frm;
            //populates comboboxes with appropriate values
            foreach (string type in Booking.podTypes)
            {
                cbPodType1.Items.Add(type);
                cbPodType2.Items.Add(type);
                cbPodType3.Items.Add(type);
            }
            foreach(string id in tblPodDAL.GetAllPodIds())
            {
                cbPodID1.Items.Add(id);
                cbPodID2.Items.Add(id);
            }
        }

        private void btnEditPod_Click(object sender, EventArgs e)
        {
           
            lblError1.ForeColor = Color.Red;
            lblError1.Visible = false;

            try
            {
                string podType = cbPodType1.Text;
                string podIdText = cbPodID1.Text;
                bool valid = true;

                if (String.IsNullOrEmpty(podType))
                {
                    lblPodType1.ForeColor = Color.Red;
                    valid = false;
                }
                else
                {
                    lblPodType1.ForeColor = Color.Black;
                }
                if (String.IsNullOrEmpty(podIdText))
                {
                    lblPodID.ForeColor = Color.Red;
                    valid = false;
                }
                else
                {
                    lblPodID.ForeColor = Color.Black;
                    
                }
                //if input values are valid
                if (valid)
                {
                    lblError1.Visible = true;

                    if (Booking.podTypes.Contains(podType))
                    {
                        //creates a pod object and passes this to the tblPodDAL class to add to the database
                        Pod pod = new Pod(podType);
                        pod.PodID = Convert.ToInt32(cbPodID1.Text);
                        updatedPod = tblPodDAL.UpdatePod(pod);
                        //informs user if the update was successful
                        if (updatedPod)
                        {
                            lblError1.Text = "This record has been updated";
                            lblError1.ForeColor = Color.White;
                        }
                        else
                        {
                            lblError1.Text = "This is an invalid PodID";
                        }
                    }
                    else
                    {                       
                        lblError1.Text = "Please select a valid Pod Type";
                    }
                }
            }
            //catches database errors
            catch (SqlException)
            {
                lblError1.Text = "There was a problem with the database";
            }
            //catches errors with incorrect data type input
            catch (SystemException)
            {
                lblError1.Text = "Please enter a number for Pod ID";
            }
            //catches any remainder errors
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
       
        }

        private void btnEditPodDescription_Click(object sender, EventArgs e)
        {
            try
            {
                //updates the pod description object
                 updateObject();
                //updates the database with the new object
                 tblPodDescriptionDAL.UpdateRecord(podDes);
                 lblError4.ForeColor = Color.White;
                 lblError4.Visible = true;
                 lblError4.Text = "This was a successful edit";

            }
            catch(SystemException)
            {
                lblError4.Visible = true;
                lblError4.Text = "Please insert valid values";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbPodType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPodType2.Text == Booking.podTypes[0])
                {
                    //makes object then populates elements of the form with corresponding data
                    podDes = tblPodDescriptionDAL.ReturnPodDescrition(cbPodType2.Text);
                    populateElements();
                }
                else if (cbPodType2.Text == Booking.podTypes[1])
                {
                    podDes = tblPodDescriptionDAL.ReturnPodDescrition(cbPodType2.Text);
                    populateElements();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populateElements()
        {
            //populates elements of the form with the objects data and adjusts visibility
            txtboxCost.Text = podDes.CostPerPersonPerNight.ToString();
            txtboxPodDescription.Text = podDes.PodDescriptionString;
            txtboxMaxOccupants.Text = podDes.MaxOccupancy.ToString();
            lblCost.Visible = true;
            btnEditPodDescription.Visible = true;
            lblMaxOccupants.Visible = true;
            lblPodDescription.Visible = true;
            txtboxCost.Visible = true;
            txtboxMaxOccupants.Visible = true;
            txtboxPodDescription.Visible = true;
            btnClear2.Visible = true;
        }
        private void updateObject()
        {
            //updates the object to new input data
            podDes.PodDescriptionString = txtboxPodDescription.Text;
            podDes.MaxOccupancy = (int)Convert.ToInt64(txtboxMaxOccupants.Text);
            podDes.CostPerPersonPerNight = Convert.ToDouble(txtboxCost.Text);
            podDes.PodType = cbPodType2.Text;
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            //clears pod type panel
            cbPodID1.Text = string.Empty;
            cbPodType1.Text = string.Empty;
            lblError1.Visible = false;
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            //clears edit pod description panel
            lblCost.Visible = false;
            btnEditPodDescription.Visible = false;
            lblMaxOccupants.Visible = false;
            lblPodDescription.Visible = false;
            txtboxCost.Visible = false;
            txtboxMaxOccupants.Visible = false;
            txtboxPodDescription.Visible = false;
            btnClear2.Visible = false;
            lblError4.Visible = false;
            cbPodType2.Text = string.Empty;
        }


        private void btnClear3_Click(object sender, EventArgs e)
        {
            //deletes text from add pod panels
            cbPodType3.Text = string.Empty;
            lblError3.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lblError2.Visible = false;
                lblError2.ForeColor = Color.Red;
                int podID = Convert.ToInt32(cbPodID2.Text);
                //confirms user wants to delete
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show("Any bookings for these pods will be deleted. Are you sure you would like to continue?", "Confirmation", buttons);
                if (result == DialogResult.OK)
                {
                    //attempts to delete the pod of specified ID
                    if (tblPodDAL.DeletePod(podID))
                    {
                        //informs the user the pod has been deleted
                        lblError2.Visible = true;
                        lblError2.Text = "Success";
                        lblError2.ForeColor = Color.White;
                    }
                    else
                    {
                        //if no pod was deleted, user is informed
                        lblError2.Visible = true;
                        lblError2.Text = "This is an invalid Pod ID";
                    }
                }

            }
            catch (SqlException)
            {
                //catches database exceptions
                MessageBox.Show("There was a problem connection to the database");
            }
            catch (SystemException)
            {
                //catches wrong data type input
                lblError2.Visible = true;
                lblError2.Text = "This is an invalid Pod ID";
            }
            catch (Exception ex)
            {
                //catches all other exceptions
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int podID;
            lblError3.Visible = false;
            try
            {
                //if podType combobox has a value
                if (!String.IsNullOrEmpty(cbPodType3.Text))
                {
                    //check if it is a valid value
                    if (Booking.podTypes.Contains(cbPodType3.Text))
                    {
                        //create a pod object and add this object to the database
                        Pod pod = new Pod(cbPodType3.Text);
                        podID = tblPodDAL.AddPod(pod);
                        lblError3.ForeColor = Color.White;
                        lblError3.Visible = true;
                        lblError3.Text = "Success\nPodID : " + podID;
                    }
                    else
                    {
                        lblError3.Visible = true;
                        lblError3.Text = "Please enter a valid Pod Type";
                    }
                }
                else
                {
                    lblError3.Visible = true;
                    lblError3.Text = "Please enter a Pod Type";
                }
            }
            //catches database exception
            catch (SqlException)
            {
                MessageBox.Show("There was a problem connection to the database");
            }
            //catches all other exceptions
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);            
            }
        }

        private void btnClearDelete_Click(object sender, EventArgs e)
        {
            //clears text from panel delete pod
            lblError2.Visible=false;
            cbPodID2.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.btnEditPod.BackColor = Color.WhiteSmoke;
        }
    }
}
