using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;


namespace Menu_Restaurante
{
    public partial class productoForm : Form
    {
        public productoForm()
        {
            InitializeComponent();
        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo de imagenes(*jpg; *png;) | *jpg; *png;";
            if (file.ShowDialog()==DialogResult.OK)
            {
                SaveImage.Image = Image.FromFile(file.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=restaurantssq.database.windows.net;Initial Catalog=Restaurant;Persist Security Info=True;User ID=Toto28;Password=Toto2323;TrustServerCertificate=True"))
            {

                SqlCommand cmd = new SqlCommand("Insert into Productos (ID_Producto, Descripcion, Precio) values ( " + textBox5.Text + ",'" + textBox1.Text + "','" + textBox2.Text + "')", cn); ;
                cmd.CommandType = CommandType.Text;

                cn.Open();

                cmd.ExecuteNonQuery();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Categorias cat = new Categorias();  
        private void productoForm_Load(object sender, EventArgs e)
        {
          
            Categoria.DataSource = cat.comboCargar();
            Categoria.DisplayMember = "Nombre_Categoria";
            Categoria.ValueMember = "ID_Categoria";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

         
        }
    }
}
