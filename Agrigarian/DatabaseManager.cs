using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Agrigarian
{
    public class DatabaseManager
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private SqlConnection getsqlConnection()
        {
            con = new SqlConnection("Data Source=DESKTOP-NMAS1I1\\ASHANI;Initial Catalog=PROJECT_AGRICULTURE;Integrated Security=True");
            return con;
        }

        public int insertUpdateDelete(string command)
        {
            int i = 0;
            try
            {
                getsqlConnection();
                con.Open();
                cmd = new SqlCommand(command, con);
                i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
            catch(SqlException)
            {
                //
            }
            return i;
        }

        public int check(string command)
        {
            int i = 0;
            getsqlConnection();
            con.Open();
            da = new SqlDataAdapter(command, con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch(SqlException)
            {
                //
            }
            if(dt.Rows.Count > 0)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
            con.Close();
            return i;
        }

        public DataTable getData(string cmd)
        {
            try
            {
                getsqlConnection();
                con.Open();
                da = new SqlDataAdapter(cmd, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch(SqlException)
            {
                //
            }
            return null;
        }

        
        public string getValue(string cmmand, string txt, int i, int j)
        {
            getsqlConnection();
            con.Open();
            cmd = new SqlCommand(cmmand,con);
            SqlDataReader sqlrd = cmd.ExecuteReader();
            string value = null;

            if(sqlrd.HasRows)
            {
                while(sqlrd.Read())
                {
                    if(sqlrd[i].ToString() == txt)
                    {
                        value = sqlrd[j].ToString();
                        break;
                    }
                }
            }

            return value;
        }
    }
}
