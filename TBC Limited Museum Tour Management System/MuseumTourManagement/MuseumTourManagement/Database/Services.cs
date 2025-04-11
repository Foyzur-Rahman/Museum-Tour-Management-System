using System;
using System.Data.SqlClient;

namespace MuseumTourManagement.Database


{
    public class Services   // Used to authenticate username and password from the sql
    {  
        public static string AuthenticateUser(string username, string password)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT Role FROM Managers WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    object result = cmd.ExecuteScalar();

                    return result != null ? result.ToString() : null;  // Return role if found, else null
                }
            }
        }
    }
}
