using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DAL
{
    public class DataAccessLayer
    {
        static string sConn = "Data Source=DESKTOP-RVFLOIO\\MY_INSTANCE;Initial Catalog=Project-Prototype;Integrated Security=True";

        SqlConnection dbConn = new SqlConnection(sConn);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;


        public int InsertUser(classUser user)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_InsertAdmin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", user.Name);
            dbComm.Parameters.AddWithValue("@Surname", user.Surname);
            dbComm.Parameters.AddWithValue("@Surname", user.Title);
            dbComm.Parameters.AddWithValue("@Email", user.Email);
            dbComm.Parameters.AddWithValue("@Password", user.Password);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

    }

}
