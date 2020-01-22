using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace uygulama
{

    class clsDB
    {
        public static string cs = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=uygulama;Integrated Security=True;" +
            "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static DataTable veriCek ()
        {
            SqlConnection conn = new SqlConnection(cs);
            DataTable dt = new DataTable();
            string sql;
            conn.Open();
            try
            {
                sql = "SELECT * FROM bilgiler";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.Source + ex.GetType());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return dt;
        }
    }
}
