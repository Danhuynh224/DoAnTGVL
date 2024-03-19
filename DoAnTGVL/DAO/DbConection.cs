using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace DoAnTGVL.DAO
{
    internal class DbConection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
        public void Process(string sql)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sqlStr = string.Format(sql);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thanh cong");
                else
                    MessageBox.Show("Nhap sai");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
