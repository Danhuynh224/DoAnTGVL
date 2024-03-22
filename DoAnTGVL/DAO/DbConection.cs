using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using DoAnTGVL.Class;
using System.Collections;

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
        public List<Tho> ReadDatabase(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            List<Tho> DStho = new List<Tho>();
            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Tho tho = new Tho(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(),
                    (DateTime)dataReader[4], dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), dataReader[8].ToString(), (int)dataReader[9], Convert.ToSingle(dataReader[10]));
                        DStho.Add(tho);

                    }

                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return DStho;
        }

        public List<BaiDang> ReadDatabaseBaiDang(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring);
            List<BaiDang> DSbaidang = new List<BaiDang>();
            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        BaiDang baidang = new BaiDang((int)dataReader[0], dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(),
                    dataReader[5].ToString(), (DateTime)dataReader[6], dataReader[7].ToString(), dataReader[8].ToString(), dataReader[9].ToString());
                        DSbaidang.Add(baidang);

                    }

                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return DSbaidang;
        }
    }
}
