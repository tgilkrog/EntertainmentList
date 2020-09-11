using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class ELDataAccess
    {
        static string connectionString = "Server=DESKTOP-74PJPSM; Initial Catalog=MEL; Integrated Security=true";
        public EntertaintmentList GetELByUserId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[EntertainmentList], [dbo].[Movie] WHERE MovieReview.id = @id AND MovieReview.movieId = Movie.id", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();

                EntertaintmentList entertaintmentList = new EntertaintmentList();

                while (reader.Read())
                {
                 
                  
                }
                return entertaintmentList;
            };
        }
    }
}
