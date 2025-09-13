using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakesideEscapesPodBooking
{
    internal class tblCourseGuestsDAL
    {
        public static bool DoCourseDatesOverlapWithBooking(Booking booking)
        {
            List<int> CourseIDs = new List<int>();

            List<int> ApproperateCourses = new List<int>();

            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                //returns all the courseIDs of that guest
                connection.Open();
                SqlCommand ReturnCourseIDCommand = new SqlCommand("ReturnCourseIDByGuestID", connection);
                ReturnCourseIDCommand.CommandType = System.Data.CommandType.StoredProcedure;
                ReturnCourseIDCommand.Parameters.Add(new SqlParameter("@GuestID", booking.GuestID));
                using (SqlDataReader reader = ReturnCourseIDCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CourseIDs.Add(reader.GetInt32(0));
                    }
                }
                //checks if the course dates match with the booking dates
                foreach (int id in CourseIDs)
                {
                    SqlCommand CheckCourseDatesCommand = new SqlCommand("CheckCourseDates", connection);
                    CheckCourseDatesCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    CheckCourseDatesCommand.Parameters.Add(new SqlParameter("@bookingStart", booking.StartDate.Date));
                    CheckCourseDatesCommand.Parameters.Add(new SqlParameter("@bookingEnd", booking.EndDate.Date));
                    CheckCourseDatesCommand.Parameters.Add(new SqlParameter("@CourseID", id));

                    if (CheckCourseDatesCommand.ExecuteScalar() != null)
                    {
                        ApproperateCourses.Add(id);
                    }

                    //CheckCourseDatesCommand.Dispose();
                }
                //if they match then return true, if not return false
                if (ApproperateCourses.Count > 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }

        }

        public static void UpdateReportByCourseGuestsDetails(Microsoft.Reporting.WinForms.ReportViewer reportViewer)
        {
            //connect to database
            SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString);
            SqlCommand reportBookingCommand = new SqlCommand("JoinCourseWithGuestDetails", connection);
            reportBookingCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(reportBookingCommand);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "ReportCourseWithGuestDetails");
            reportViewer.LocalReport.ReportPath = "../../courseGuestsDetailsReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("ReportCourseWithGuestDetails", dataSet.Tables["ReportCourseWithGuestDetails"]);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.RefreshReport();
        }
    }
}

