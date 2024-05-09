using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace Menu_Restaurante
{
    public partial class VentanaCombos : Form
    {
        private SqlDataAdapter da;
        private DataSet ds;
        public string Categoria = "";
        public DataGridView dataGridView1 = new DataGridView();
        public VentanaCombos()
        {
            InitializeComponent();
            Poblar();
        }

        private void Poblar()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source = restaurantssq.database.windows.net; Initial Catalog = Restaurant; Persist Security Info = True; User ID = Toto28; Password = Toto2323; TrustServerCertificate = True"))
            {
                da = new SqlDataAdapter("select Id_producto, descripcion, precio from productos where categorias='combos'", conexion);
                da.SelectCommand.Parameters.AddWithValue("combos", Categoria);
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

        private void DataGridView1_VisibleChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void comboForm_Load(object sender, EventArgs e)
        {
            Poblar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VentanaCombos_Load(object sender, EventArgs e)
        {
            Poblar();

        }
    }
}
