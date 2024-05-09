using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Restaurante
{
    public partial class ventaPostres : Form
    {
        private SqlDataAdapter da;
        private DataSet ds;
        public string Categoria = "";
        public DataGridView dataGridView1 = new DataGridView();
        public ventaPostres()
        {
            InitializeComponent();
        }

        private void Poblar()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source = restaurantssq.database.windows.net; Initial Catalog = Restaurant; Persist Security Info = True; User ID = Toto28; Password = Toto2323; TrustServerCertificate = True"))
            {
                da = new SqlDataAdapter("select Id_producto, descripcion, precio from productos where categorias='Postres'", conexion);
                da.SelectCommand.Parameters.AddWithValue("Postres", Categoria);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ComboForm.AutoGenerateColumns = false;
                    ComboForm.DataSource = ds.Tables[0];
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
        }
        private void ventaPostres_Load(object sender, EventArgs e)
        {
            Poblar();   
        }

        private void ComboForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.CurrentRow.Cells["CANTIDAD"].Value != null)
                {
                    // Realizar alguna acción si el valor no es nulo
                }
                else
                {
                    dataGridView1.CurrentRow.Cells["CANTIDAD"].Value = 1;
                }
            }
        }

        private void ComboForm_VisibleChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                using (SqlConnection conexion = new SqlConnection("Data Source = restaurantssq.database.windows.net; Initial Catalog = Restaurant; Persist Security Info = True; User ID = Toto28; Password = Toto2323; TrustServerCertificate = True")) // Reemplaza "TuCadenaDeConexion" con tu cadena de conexión
                {
                    da = new SqlDataAdapter("select * from productos where Id_producto=@Id", conexion);
                    da.SelectCommand.Parameters.AddWithValue("@Id", fila.Cells["ID"].Value);
                    ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        // Hacer algo si hay datos
                    }
                }
            }
        }
    }
}
    

