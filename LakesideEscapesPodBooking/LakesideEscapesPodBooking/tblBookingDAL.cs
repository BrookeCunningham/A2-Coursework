using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakesideEscapesPodBooking
{
    internal class tblBookingDAL
    {
        static int bookingID;

        static List<int> vacentPods = new List<int>();


        //adds a booking
        public static int addBooking(Booking booking)
        {
            //creates sql connection
            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                //calls stored procedure and passes through booking object data
                connection.Open();
                SqlCommand addBookingCommand = new SqlCommand();
                addBookingCommand.Connection = connection;
                addBookingCommand.CommandType = System.Data.CommandType.StoredProcedure;
                addBookingCommand.CommandText = "AddBooking";
                addBookingCommand.Parameters.Add(new SqlParameter("@BookingStartDate", booking.StartDate));
                addBookingCommand.Parameters.Add(new SqlParameter("@BookingEndDate", booking.EndDate));
                addBookingCommand.Parameters.Add(new SqlParameter("@NoOfOccupants", booking.NoOfOccupants));
                addBookingCommand.Parameters.Add(new SqlParameter("@DepositPaid", booking.DepositPaid));
                addBookingCommand.Parameters.Add(new SqlParameter("@GuestID", booking.GuestID));
                addBookingCommand.Parameters.Add(new SqlParameter("@AttendingCourse", booking.AttendingCourse));
                addBookingCommand.Parameters.Add(new SqlParameter("@PodID", booking.PodID));
                addBookingCommand.Parameters.Add(new SqlParameter("@DateBooked", booking.DateBooked));
                //executes stored procedure
                bookingID = Convert.ToInt32(addBookingCommand.ExecuteScalar());

                connection.Close();
            }
            //returns the unique autoincremented bookingID assigned to the data
            return bookingID;
        }

        //returns any vacent pods between a set of dates
        public static List<int> ReturnsVacentPodIDs(DateTime start, DateTime end, List<int> podIDs)
        {
            vacentPods.Clear();

            //opens sql connection
            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();

                foreach (int podID in podIDs)
                {
                    SqlCommand ReturnPodCommand = new SqlCommand("ReturnsVacentPods", connection);
                    ReturnPodCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    ReturnPodCommand.Parameters.Add(new SqlParameter("@start", start));
                    ReturnPodCommand.Parameters.Add(new SqlParameter("@end", end));
                    ReturnPodCommand.Parameters.Add(new SqlParameter("@PodID", podID));

                    using (SqlDataReader reader = ReturnPodCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            // if there are no rows, then there are no bookings for this PodID in the given date range
                            //and it is added to the list
                            vacentPods.Add(podID);
                        }
                    }
                }
            }

            return vacentPods;
        }

        //deletes a booking
        public static void DeleteBooking(int bookingID)
        {
            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();
                SqlCommand deleteBookingCommand = new SqlCommand();
                deleteBookingCommand.Connection = connection;
                deleteBookingCommand.CommandType = System.Data.CommandType.StoredProcedure;
                deleteBookingCommand.CommandText = "DeleteBooking";
                deleteBookingCommand.Parameters.Add(new SqlParameter("@BookingID", bookingID));
                //executes stored procedure
                deleteBookingCommand.ExecuteNonQuery();
            }

        }

        //returns a booking object when given the bookingID
        public static Booking GetBookingObjectFromID(int bookingID)
        {
            Booking booking = null;

            //opens sql connection to database and populates a user object with the data
            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();
                SqlCommand returnBookingCommand = new SqlCommand();
                returnBookingCommand.Connection = connection;
                returnBookingCommand.CommandType = System.Data.CommandType.StoredProcedure;
                returnBookingCommand.CommandText = "GetBookingRecordFromBookingID";
                returnBookingCommand.Parameters.Add(new SqlParameter("@BookingID", bookingID));
                using (SqlDataReader reader = returnBookingCommand.ExecuteReader())
                {
                    //reads the returned data from the sql query into a booking object
                    if (reader.Read())
                    {
                        booking = new Booking(
                            Convert.ToDateTime(reader["BookingStartDate"]),
                            Convert.ToDateTime(reader["BookingEndDate"]),
                            Convert.ToInt16(reader["NoOfOccupants"]),
                            Convert.ToInt16(reader["PodID"]),
                            Convert.ToString(reader["DepositPaid"]),
                            Convert.ToString(reader["AttendingCourse"]),
                            Convert.ToDateTime(reader["DateBooked"]),
                            Convert.ToInt16(reader["GuestID"])
                        );
                    }
                }

                return booking;
            }
        }
        //when a booking is made, this applys and records any discounts which are applicable
        public static void ApplyDiscounts(Booking booking)
        {
            double discount = 0;

            //checks if Guest has previous bookings
            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();

                using (SqlCommand selectBookingsCommand = new SqlCommand("SELECT * FROM tblBooking WHERE GuestID = @GuestID", connection))
                {
                    selectBookingsCommand.Parameters.Add(new SqlParameter("@GuestID", booking.GuestID));

                    using (SqlDataReader reader = selectBookingsCommand.ExecuteReader())
                    {
                        int rowCount = 0;
                        while (reader.Read())
                        {
                            rowCount++;
                        }
                        //booking has been added to database already, so there should only be a single booking
                        if (rowCount > 1)
                        {
                            discount += 2;
                        }
                    }
                }

            }
            //checks if booking is 6 months in advance
            if (booking.DateBooked.AddMonths(6) < booking.StartDate)
            {
                discount += 3;
            }
            //updates the discount in database
            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();

                using (SqlCommand updateDiscountCommand = new SqlCommand("UPDATE tblBooking SET Discount = @NewDiscount WHERE BookingID = @BookingID", connection))
                {
                    updateDiscountCommand.Parameters.Add(new SqlParameter("@BookingID", booking.BookingID));
                    updateDiscountCommand.Parameters.Add(new SqlParameter("@NewDiscount", discount));
                    updateDiscountCommand.ExecuteNonQuery();
                }
            }

        }

        //deletes any bookings where the deposit has not been payed within three days
        //is called when program runs
        public static void DeleteBookingsWithDepositNotPaid()
        {
            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();

                string deleteExpiredBookingsCommand = @"DELETE FROM tblBooking WHERE DepositPaid = 'F' 
                AND DateBooked < @ThreeDaysAgo";

                using (SqlCommand deleteBookingsCommand = new SqlCommand(deleteExpiredBookingsCommand, connection))
                {
                    deleteBookingsCommand.Parameters.AddWithValue("@ThreeDaysAgo", DateTime.Now.AddDays(-3));
                    deleteBookingsCommand.ExecuteNonQuery();
                }

            }
        }

        //updates the booking with the new data in the booking object
        public static void UpdateBooking(Booking booking)
        {
            using (SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();
                SqlCommand editBookingCommand = new SqlCommand();
                editBookingCommand.Connection = connection;
                editBookingCommand.CommandType = System.Data.CommandType.StoredProcedure;
                editBookingCommand.CommandText = "UpdateBooking";
                //updates database values with object details 
                editBookingCommand.Parameters.Add(new SqlParameter("@BookingID", booking.BookingID));
                editBookingCommand.Parameters.Add(new SqlParameter("@BookingStartDate", booking.StartDate));
                editBookingCommand.Parameters.Add(new SqlParameter("@BookingEndDate", booking.EndDate));
                editBookingCommand.Parameters.Add(new SqlParameter("@NoOfOccupants", booking.NoOfOccupants));
                editBookingCommand.Parameters.Add(new SqlParameter("@DepositPaid", booking.DepositPaid));
                editBookingCommand.Parameters.Add(new SqlParameter("@GuestID", booking.GuestID));
                editBookingCommand.Parameters.Add(new SqlParameter("@AttendingCourse", booking.AttendingCourse));
                editBookingCommand.Parameters.Add(new SqlParameter("@PodID", booking.PodID));
                editBookingCommand.Parameters.Add(new SqlParameter("@DateBooked", booking.DateBooked));
                editBookingCommand.ExecuteScalar();

                connection.Close();
            }
        }

        //loads the rate of booking line graph report
        public static void LoadBookingGraphReport(Microsoft.Reporting.WinForms.ReportViewer reportViewer)
        {
            //connect to database
            SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString);
            //link to stored procedure
            SqlCommand reportBookingsCommand = new SqlCommand("GetMonthlyBookings", connection);
            reportBookingsCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(reportBookingsCommand);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "rateOfBookingsDataSet");
            reportViewer.LocalReport.ReportPath = "../../bookingRateGraphReport.rdlc";
            reportViewer.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("rateOfBookingsDataSet", dataSet.Tables["rateOfBookingsDataSet"]);
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.RefreshReport();
        }

    }
}





