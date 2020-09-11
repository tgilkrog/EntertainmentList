using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ModelLayer
{
    public class UserDataAccess
    {
        static string connectionString = "Server=DESKTOP-74PJPSM; Initial Catalog=MEL; Integrated Security=false";

        public MELUser GetUserByID(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[MELUser] WHERE id = @id", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();

                MELUser melUser = new MELUser();

                while (reader.Read())
                {
                    melUser = new MELUser()
                    {
                        UserID = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                    };
                }
                return melUser;
            };
        }
    }
}
