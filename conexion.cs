using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Menu_Restaurante
{
    public class conexion
    {
        public SqlConnection LeerCadena()
        {
            SqlConnection cn = new SqlConnection("Data Source = restaurantssq.database.windows.net; Initial Catalog = Restaurant; Persist Security Info = True; User ID = Toto28; Password = Toto2323; TrustServerCertificate = True");

            if (cn.State == ConnectionState.Open)
            {
                cn.Close(); 
            }
            else
            {
                cn.Open();
            }
            return cn;
        }
    }
}
