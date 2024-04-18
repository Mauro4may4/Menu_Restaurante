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

namespace Menu_Restaurante
{
    public partial class VentanaCombos : Form
    {
        public VentanaCombos()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server= DODO; database = Restaurant_; password = Toto2323; user = Toto28; integrated security = true");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}
