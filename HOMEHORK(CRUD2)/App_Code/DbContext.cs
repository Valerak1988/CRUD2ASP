using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DATA
{
    public class DbContext
    {
        public string ConnStr {  get; set; }
        public SqlConnection Conn {  get; set; }

        public DbContext() 
        {
            ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            Conn = new SqlConnection(ConnStr);
            Conn = new SqlConnection(ConnStr);
            Conn.Open();
        }
        public void Close()
        {
            Conn.Close();
        }

        public int ExecuteNonQuery(string Sql)
        {
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            return Cmd.ExecuteNonQuery();
        }
        public DataTable Execute(string Sql)
        {
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }
    }
}