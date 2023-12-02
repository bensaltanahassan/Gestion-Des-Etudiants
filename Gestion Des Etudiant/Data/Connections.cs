using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Des_Etudiant.Data
{
    public class Connections
    {
        private String strConn = "Data Source=PC\\SQLEXPRESS;Initial Catalog=\"Gestion_Etudiant\";Integrated Security=True;";
        static public SqlConnection connection;
        public void connecte()
        {
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = strConn;
                connection.Open();
          
            }
            catch(Exception e)
            {
                MessageBox.Show($"Not Connect To DB {e.Message}");
            }

        }

        public Connections()
        {
            connecte();
        }
    }
}
