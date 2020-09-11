using ModelLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class UserDataAccess
    {
        static string connectionString = "Server=DESKTOP-74PJPSM; Initial Catalog=MEL; Integrated Security=true";

        public void CreateUser(MELUser user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert Into [dbo].[MELUser](userName, userPassword, userEmail) values(@userName, @userPassword, @userEmail)";
                    cmd.Parameters.AddWithValue("userName", user.UserName);
                    cmd.Parameters.AddWithValue("userPassword", user.Password);
                    cmd.Parameters.AddWithValue("userEmail", user.Email);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

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
                        Password = reader.GetString(2),
                        Email = reader.GetString(3),
                        FullName = reader.GetString(4),
                        ProfilePicture = reader.GetString(5),
                        FavoriteCategory = reader.GetString(6)
                    };
                }
                return melUser;
            };
        }

        public MELUser UserLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * From [dbo].[MELUser] WHERE username = @userName AND userPassword = @userPassword", connection);
                connection.Open();

                cmd.Parameters.AddWithValue("userName", username);
                cmd.Parameters.AddWithValue("userPassword", password);
                var reader = cmd.ExecuteReader();

                MELUser melUser = new MELUser();

                while (reader.Read())
                {
                    melUser = new MELUser()
                    {
                        UserID = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                        Password = reader.GetString(2),
                        Email = reader.GetString(3),
                        FullName = reader.GetString(4),
                        ProfilePicture = reader.GetString(5),
                        FavoriteCategory = reader.GetString(6)
                    };
                }
                return melUser;
            };
        }
    }
}
