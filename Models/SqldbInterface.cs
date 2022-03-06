using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MVCproject.Models
{
    public class SqldbInterface
    {
        SqlConnection con;
        SqlCommand cmd;
        public SqldbInterface()
        {
            con = new SqlConnection("Data Source=LAPTOP-SPA4TKP0; database=Restaurant; Integrated Security=True;");
        }
        public bool TableReservation(TableRes tblres)
        {
            cmd = new SqlCommand("proc_TblRes", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", tblres.Name);
            cmd.Parameters.AddWithValue("@Email", tblres.Email);
            cmd.Parameters.AddWithValue("@Phone", tblres.Phone);
            cmd.Parameters.AddWithValue("@NoPerson", tblres.NoPerson);
            cmd.Parameters.AddWithValue("@Date", tblres.Date);
            cmd.Parameters.AddWithValue("@Time", tblres.Time);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                return true;
            else
                return false;
        }
    }
}