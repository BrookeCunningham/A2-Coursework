using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakesideEscapesPodBooking
{
    internal class tblPodDescriptionDAL
    {
        //updates a pods description    
       public static void UpdateRecord(PodDescription podDescription)
       {
            using(SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();
                SqlCommand UpdatePodDescription = new SqlCommand();
                UpdatePodDescription.Connection = connection;
                UpdatePodDescription.CommandType = System.Data.CommandType.StoredProcedure;
                UpdatePodDescription.CommandText = "UpdatePodDescription";
                UpdatePodDescription.Parameters.Add(new SqlParameter("@PodType", podDescription.PodType));
                UpdatePodDescription.Parameters.Add(new SqlParameter("@PodDescription", podDescription.PodDescriptionString));
                UpdatePodDescription.Parameters.Add(new SqlParameter("@PodCostPerPersonPerNight",podDescription.CostPerPersonPerNight));
                UpdatePodDescription.Parameters.Add(new SqlParameter("@MaxOccupancy",podDescription.MaxOccupancy));
                UpdatePodDescription.ExecuteReader();
            }

       }

        //returns a podDescription object when given the type
       public static PodDescription ReturnPodDescrition(string podType)
       {
            PodDescription podDes;

            using(SqlConnection connection = new SqlConnection(tblGuestDAL._connectionString))
            {
                connection.Open();
                SqlCommand ReturnPodDescription = new SqlCommand();
                ReturnPodDescription.Connection = connection;
                ReturnPodDescription.CommandType = System.Data.CommandType.StoredProcedure;
                ReturnPodDescription.CommandText = "ReturnPodDescription";
                ReturnPodDescription.Parameters.Add(new SqlParameter("@PodType", podType));
                using (SqlDataReader reader = ReturnPodDescription.ExecuteReader())
                {
                    //writes the data into the object
                    if (reader.Read())
                    {
                        podDes = new PodDescription(
                            podType,
                            reader["PodDesription"].ToString(),
                            Convert.ToInt32(reader["MaxOccupancy"]),
                            Convert.ToDouble(reader["PodCostPerPersonPerNight"])
                        );
                    }
                    //if the type is not found, set the object to null
                    else
                    {
                        podDes = null;
                    }
                }

            }

            return podDes;
       }


    }
}
