using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WalletApp.DataAccess
{
    public class DAL
    {
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WalletAppCon"].ToString());
        public static bool UserIsValid(string username, string password) {
            bool authenticated = false;
            string query = string.Format("SELECT * FROM [User] WHERE username = '{0}' AND password = '{1}'",username,password);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            authenticated = sdr.HasRows;
            conn.Close();
            return (authenticated);
        }
    }
}