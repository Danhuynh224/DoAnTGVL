using DoAnTGVL.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace DoAnTGVL.DAO
{
    
    public class DAOTho

    {
        int i = 0;
        public List<Tho> ReadDatabase()
        {
            
            string query = "Select * From Tho";
            List<Tho> DStho= new List<Tho>();
            
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstring))
            {
                
                SqlCommand command = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader dataReader  = command.ExecuteReader();

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
    }
}
