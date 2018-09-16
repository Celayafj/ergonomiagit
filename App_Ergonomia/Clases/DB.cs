using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace App_Ergonomia.Clases
{
    static class DB
    {
        private static string query { get; set; }
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;
        private static SqlDataReader sqlDataReader;
        public static bool Login(string username, string password)
        {
            query = "SELECT USERS.UserID FROM USERS WHERE UserName = @Name AND UserPassword = @Password";
           sqlConnection = new SqlConnection()
            {
                ConnectionString = DbConnection.GetConnection()
            };
            sqlCommand = new SqlCommand(query,sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name",username);
            sqlCommand.Parameters.AddWithValue("@Password",password);
            try
            {
                sqlConnection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                if(sqlDataReader.HasRows)
                {
                    return true;//Login succesful
                }
                else
                {
                    return false;//Login failed
                } 
            }
            catch(Exception)
            {
               MessageBox.Show("Connection failed");
            }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }
    }
}
