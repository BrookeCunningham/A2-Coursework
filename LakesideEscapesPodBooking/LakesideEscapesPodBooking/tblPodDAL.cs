using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakesideEscapesPodBooking
{
    internal class tblPodDAL
    {
        public static List<int> podIDs = new List<int>();

        //returns a list of pod IDs of the given type
        public static List<int> ReturnReleventPodIDs(string podType)
        {
            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                podIDs.Clear();
                connection.Open();
                SqlCommand podTypeCommand = new SqlCommand();
                podTypeCommand.Connection = connection;
                podTypeCommand.CommandType = System.Data.CommandType.StoredProcedure;
                podTypeCommand.CommandText = "GetPodIDFromType";
                podTypeCommand.Parameters.Add(new SqlParameter("@podType", podType));
                using (SqlDataReader reader = podTypeCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int podID = reader.GetInt32(0);
                        podIDs.Add(podID);
                    }
                }
                return podIDs;
            }
        }

        //returns the pod type given the podID
        public static string GetPodType(int podID)
        {
            string podType = "";
            string connectionString = tblGuestDAL._connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand getTypeCommand = new SqlCommand("SELECT podType FROM tblPod WHERE PodID = @podID", connection))
                {
                    getTypeCommand.Parameters.AddWithValue("@podID", podID);

                    SqlDataReader reader = getTypeCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        podType = reader["podType"].ToString();
                    }
                }
            }

            return podType;
        }

        //adds a pod to the database
        public static int AddPod(Pod pod)
        {
            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();
                SqlCommand AddPodCommand = new SqlCommand();
                AddPodCommand.Connection = connection;
                AddPodCommand.CommandType = System.Data.CommandType.StoredProcedure;
                AddPodCommand.CommandText = "AddPod";
                AddPodCommand.Parameters.Add(new SqlParameter("@PodType", pod.PodType));
                int podID = Convert.ToInt32(AddPodCommand.ExecuteScalar());

                return podID;
            }
        }

        //populates a datagridview using an inner join, to show both the podID and its type and the details of that type
        public static void PopulateDGVGivenPod(int podId, DataGridView dgv)
        {
            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();
                using (SqlCommand dgvPodCommand = new SqlCommand("PopulateDGVGivenPod", connection))
                {
                    dgvPodCommand.CommandType = CommandType.StoredProcedure;
                    dgvPodCommand.Parameters.AddWithValue("@podId", podId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(dgvPodCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgv.DataSource = dataTable;
                    }
                }
            }
        }

        //returns all the podIDs, is used to populate combo boxes
        public static List<string> GetAllPodIds()
        {
            List<string> podIds = new List<string>();

            string query = "SELECT podId FROM tblPod";

            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();
                using (SqlCommand returnPodIDsCommand = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = returnPodIDsCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            podIds.Add(reader["podId"].ToString());
                        }
                    }
                }
            }

            return podIds;
        }

        //updates the pod using the pod object
        public static bool UpdatePod(Pod pod)
        {
            int rows;

            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();
                SqlCommand EditPodCommand = new SqlCommand();
                EditPodCommand.Connection = connection;
                EditPodCommand.CommandType = System.Data.CommandType.StoredProcedure;
                EditPodCommand.CommandText = "UpdatePod";
                EditPodCommand.Parameters.Add(new SqlParameter("@PodType", pod.PodType));
                EditPodCommand.Parameters.Add(new SqlParameter("@PodID", pod.PodID));
                rows = EditPodCommand.ExecuteNonQuery();
            }
            //if podID is invalid
            if(rows!=0)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        //deletes a pod with the given podID
        public static bool DeletePod(int podID)
        {
            int rows;

            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();
                SqlCommand deletePodCommand = new SqlCommand();
                deletePodCommand.Connection = connection;
                deletePodCommand.CommandType = System.Data.CommandType.StoredProcedure;
                deletePodCommand.CommandText = "DeletePod";
                deletePodCommand.Parameters.Add(new SqlParameter("@PodID", podID));
                rows = deletePodCommand.ExecuteNonQuery();
            }
            //if podID exists
            if (rows != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //loads report ordered by the popularity of specific pods
        public static void UpdateReportByFrequencyOfPodIDs(Microsoft.Reporting.WinForms.ReportViewer reportViewer)
        {
            //connect to database
            SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString);
            SqlCommand podReportCommand = new SqlCommand("ReturnPodFrequency", connection);
            podReportCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(podReportCommand);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "tblPodDataSetReport");
            reportViewer.LocalReport.ReportPath = "../../podReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("tblPodDataSetReport", dataSet.Tables["tblPodDataSetReport"]);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.RefreshReport();
        }



    }
}
