using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BabyShop.DataAccess
{
   public class Connection
    {
        SqlConnection con = new SqlConnection();
        internal SqlConnection Returnconnection()
        {
            try
            {
                string connectionstring = System.Configuration.ConfigurationManager.AppSettings["BabyShop"].ToString();
                con = new SqlConnection(connectionstring);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return con;
        }
    }
}
