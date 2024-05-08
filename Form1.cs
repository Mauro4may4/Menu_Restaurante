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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Imaging;

namespace Menu_Restaurante
{
    public partial class Form1 : Form
    {
        SqlConnection conex = new SqlConnection("Data Source = restaurantssq.database.windows.net; Initial Catalog = Restaurant; Persist Security Info = True; User ID = Toto28; Password = Toto2323; TrustServerCertificate = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            conex.Open();
            string consult = "Select * from Users where nombre ='" + txtUsuario.Text + "' and contrasena = '" + txtContra.Text + "'";
            SqlCommand comando = new SqlCommand(consult, conex);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                productoForm bienvenido = new productoForm();
                this.Hide();
                bienvenido.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Datos incorrectos!");
            }

            conex.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
