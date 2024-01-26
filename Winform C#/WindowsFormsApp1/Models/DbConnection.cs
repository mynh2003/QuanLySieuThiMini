using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace WindowsFormsApp1.Models
{
    
    public class DbConnection
    {
        public SqlConnection conn;
        public string sql = null;
        public void OpenConn()
        {
            string chuoiketnoi = ConfigurationManager.ConnectionStrings["ckn"].ConnectionString;
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
        }
        
        public DataTable readData(string sqlSelect)
        {
            DataTable dt = new DataTable();       
            OpenConn();
            SqlDataAdapter sda = new SqlDataAdapter(sqlSelect, conn);
            sda.Fill(dt);
            CloseConn();
            sda.Dispose();
            return dt;
        }
        public void changeData(string sql)
        {
            OpenConn();
            SqlCommand sc = new SqlCommand();
            sc.Connection = conn;
            sc .CommandText = sql;
            sc.ExecuteNonQuery();
            CloseConn();
            sc.Dispose();
        }
        public string selectData(string sql)
        {
            OpenConn();
            SqlCommand sc = new SqlCommand();
            sc.Connection = conn;
            sc.CommandText = sql;
            string text = sc.ExecuteScalar().ToString();
            CloseConn();
            sc.Dispose();
            return text;
        }
       public SqlDataAdapter readDataProcedure(string nameProc, string parameter)
       {
            OpenConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = nameProc;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.Add(new SqlParameter("@MaPN", SqlDbType.VarChar, 50)).Value = parameter;
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            return dap;
        }
        public void CloseConn()
        {
            conn.Close();
        }
    }
}
