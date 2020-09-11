using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.dll;
using System.Data.SqlClient;

namespace ModelLayer
{
    public class UserDataAccess
    {
        static string connectionString = "Server=TG; Initial Catalog=MEL; Integrated Security=true";

        public MELUser UserByID(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[bookKUser]", connection);
                connection.Open();
                var reader = cmd.ExecuteReader();

                List<User> users = new List<User>();

                while (reader.Read())
                {
                    users.Add(new User()
                    {
                        UserID = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                    });
                }
                return 1;
            };
        }
    }
}
