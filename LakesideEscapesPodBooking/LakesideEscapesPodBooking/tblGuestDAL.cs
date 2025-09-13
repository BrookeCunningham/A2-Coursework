using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LakesideEscapesPodBooking
{
    internal class tblGuestDAL
    {
        //guestID which is returned when a guest is created
        private static int guestIDAddGuest;
        //creates guest object which is returned
        Guest guest = new Guest("", "", "", "", "", "", "", "", "", "", "", "",DateTime.Now);
        //connection string to database
        public static string _connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        //method to add a guest to the database
        public static int AddGuest(Guest guest)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand addGuestCommand = new SqlCommand();
                addGuestCommand.Connection = connection;
                addGuestCommand.CommandType = System.Data.CommandType.StoredProcedure;
                addGuestCommand.CommandText = "AddGuest";
                addGuestCommand.Parameters.Add(new SqlParameter("@Title", guest.Title));
                addGuestCommand.Parameters.Add(new SqlParameter("@FirstName", guest.FirstName));
                addGuestCommand.Parameters.Add(new SqlParameter("@Surname", guest.Surname));
                addGuestCommand.Parameters.Add(new SqlParameter("@Email", guest.Email));
                addGuestCommand.Parameters.Add(new SqlParameter("@PhoneNumber", guest.PhoneNumber));
                addGuestCommand.Parameters.Add(new SqlParameter("@Notes", guest.Notes));
                addGuestCommand.Parameters.Add(new SqlParameter("@AddressLine1", guest.Address1));
                addGuestCommand.Parameters.Add(new SqlParameter("@AddressLine2", guest.Address2));
                addGuestCommand.Parameters.Add(new SqlParameter("@County", guest.County));
                addGuestCommand.Parameters.Add(new SqlParameter("@Country", guest.Country));
                addGuestCommand.Parameters.Add(new SqlParameter("@Postcode", guest.Postcode));
                addGuestCommand.Parameters.Add(new SqlParameter("@Gender", guest.Gender));
                addGuestCommand.Parameters.Add(new SqlParameter("@DateOfBirth", guest.DateOfBirth));
                guestIDAddGuest = (Convert.ToInt32(addGuestCommand.ExecuteScalar()));

            }
            //returns the guestID assigned to this record by the database
            return guestIDAddGuest;
        }

        //returns a guest object when given the guestID
        public static Guest ReturnGuest(int guestID)
        {
            Guest guest = null;

            //opens sql connection to database and populates a guest object with the data
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                
                    connection.Open();
                    SqlCommand returnGuestCommand = new SqlCommand();
                    returnGuestCommand.Connection = connection;
                    returnGuestCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    returnGuestCommand.CommandText = "GetGuestRecordFromGuestID";
                    returnGuestCommand.Parameters.Add(new SqlParameter("@guest_id", guestID));
                    using (SqlDataReader reader = returnGuestCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            guest = new Guest(
                                reader["Title"].ToString(),
                                reader["FirstName"].ToString(),
                                reader["Surname"].ToString(),
                                reader["Email"].ToString(),
                                reader["PhoneNumber"].ToString(),
                                reader["Notes"].ToString(),
                                reader["AddressLine1"].ToString(),
                                reader["AddressLine2"].ToString(),
                                reader["County"].ToString(),
                                reader["Country"].ToString(),
                                reader["Postcode"].ToString(),
                                reader["Gender"].ToString(),
                                Convert.ToDateTime(reader["DateOfBirth"])
                            );
                        }
                    }
                
                return guest;
            };
        }

        //returns a list of all the corresponding guestIDs when given the surname and postcode
        public static List<int> GetGuestIDsFromDetails(string surname, string postcode)
        {
            List<int> guestIDs = new List<int>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand returnGuestCommand = new SqlCommand();
                returnGuestCommand.Connection = connection;
                returnGuestCommand.CommandText = "ReturnGuestIDFromDetails";
                returnGuestCommand.CommandType = System.Data.CommandType.StoredProcedure;
                returnGuestCommand.Parameters.Add(new SqlParameter("Surname", surname));
                returnGuestCommand.Parameters.Add(new SqlParameter("Postcode", postcode));

                using (SqlDataReader reader = returnGuestCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int guestID = Convert.ToInt32(reader["GuestID"]);
                        guestIDs.Add(guestID);
                    }
                }
            }

            return guestIDs;
        }
        //updates the guest record in the database when given the guest object
        public static bool UpdateGuest(Guest newGuest)
        {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand updateGuestCommand = new SqlCommand();
                    updateGuestCommand.Connection = connection;
                    updateGuestCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    updateGuestCommand.CommandText = "UpdateGuest";
                    updateGuestCommand.Parameters.Add(new SqlParameter("@GuestID", newGuest.GuestID));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@Title", newGuest.Title));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@FirstName", newGuest.FirstName));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@Surname", newGuest.Surname));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@Email", newGuest.Email));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@PhoneNumber", newGuest.PhoneNumber));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@Notes", newGuest.Notes));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@AddressLine1", newGuest.Address1));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@AddressLine2", newGuest.Address2));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@County", newGuest.County));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@Country", newGuest.Country));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@Postcode", newGuest.Postcode));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@Gender", newGuest.Gender));
                    updateGuestCommand.Parameters.Add(new SqlParameter("@DateOfBirth", newGuest.DateOfBirth));
                    updateGuestCommand.ExecuteNonQuery();
                }

                return true;         
        }

        //loads report listed by frequency of guests
        public static void UpdateReportByFrequencyOfGuestIDs(Microsoft.Reporting.WinForms.ReportViewer reportViewer)
        {
            //connects to database
            SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString);
            SqlCommand returnGuestsCommand = new SqlCommand("ReturnGuestFrequency", connection);
            returnGuestsCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(returnGuestsCommand);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "tblGuestDataSetReport");
            reportViewer.LocalReport.ReportPath = "../../guestReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("tblGuestDataSetReport", dataSet.Tables["tblGuestDataSetReport"]);
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.RefreshReport();
        }



    }




}





