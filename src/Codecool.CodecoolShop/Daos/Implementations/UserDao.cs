using Codecool.CodecoolShop.Models;
using System;
using System.Data.SqlClient;

namespace Codecool.CodecoolShop.Daos.Implementations
{
    public class UserDao
    {

        public bool IsUserByEmail(User user)
        {
            bool success = false;
            string SQLstatment = "SELECT * FROM dbo.Users WHERE EMAIL= @email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(SQLstatment, connection);
                command.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 100).Value = user.Email;


                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return success;
        }
        public bool RegisterNewUser(User user)
        {
            bool success = false;
            if (!IsUserByEmail(user))
            {
                string SQLstatment =
                    "Insert Into dbo.Users (EMAIL, PASSWORD, ADMIN) values (@email, @password, @admin);";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(SQLstatment, connection);
                    command.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 100).Value = user.Email;
                    command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 40).Value = user.Password;
                    command.Parameters.Add("@admin", System.Data.SqlDbType.Bit).Value = user.Admin;


                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return success;
        }
    }
}
