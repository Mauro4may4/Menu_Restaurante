using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Restaurante
{
    public class Categorias
    {
        conexion cn = new conexion();   

        public DataTable comboCargar ()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_cargarcombobox", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            return dt;
        }
    }
}
