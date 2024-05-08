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
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            if (dataGridView1.Rows.Count > 0)
            {
                textID.Text = dataGridView1.CurrentRow.Cells["ID_producto"].Value.ToString();
                textprecio.Text = dataGridView1.CurrentRow.Cells["PRECIO"].Value.ToString();
                textDescription.Text = dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                Categoria.Text = dataGridView1.CurrentRow.Cells["Categorias"].Value.ToString();
              

               
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private byte[] GetBytes(Image imageIN)
        {
            MemoryStream ms = new MemoryStream();
            imageIN.Save(ms, ImageFormat.Png);  
            return ms.ToArray();
        }
        
  



        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        Categorias cat = new Categorias();
        public void productoForm_Load(object sender, EventArgs e)

        {
            Poblar();
            Categoria.DataSource = cat.comboCargar();
            Categoria.DisplayMember = "Nombre_Categoria";
            Categoria.ValueMember = "ID_categoria";
        }

        SqlConnection conex = new SqlConnection("Data Source = restaurantssq.database.windows.net; Initial Catalog = Restaurant; Persist Security Info = True; User ID = Toto28; Password = Toto2323; TrustServerCertificate = True");
        private void Poblar()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("select * from productos where descripcion like '%" + textboxbuscar.Text + "%'", conex);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                dataGridView1.DataSource = null;
            }
            conex.Close();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            textID.Text = "0";
            textDescription.Clear();
            textprecio.Clear();
            Categoria.SelectedIndex = -1;
           

            textDescription.Focus();
        }

        conexion cn = new conexion();

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection("Server=restaurantssq.database.windows.net; Database=Restaurant; User ID=Toto28; Password=Toto2323; Trusted_Connection=False; Encrypt=True;");
                OleDbConnection oleCon = new OleDbConnection("Provider=SQLOLEDB;Data Source=restaurantssq.database.windows.net;Initial Catalog=Restaurant;Persist Security Info=True;User ID=Toto28;Password=Toto2323;");

                oleCon.Open();

                if (Convert.ToInt32(textID.Text) >= 1 && Convert.ToInt32(textID.Text) <= 100)
                {

                    OleDbCommand cmd = new OleDbCommand("insert into productos (Id_producto,descripcion,precio,categorias) values('" + textID.Text + "','" + textDescription.Text + "','" + textprecio.Text  + "','" + Categoria.Text + "')", oleCon);
                    cmd.ExecuteNonQuery();

                    Poblar();
                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand("update productos set descripcion='" + textDescription.Text + "',precio='" + textprecio.Text + "',Categorias='" + Categoria.Text + "' where Id_producto=" + textID.Text, oleCon);
                    cmd.ExecuteNonQuery();

                    Poblar();
                }
                oleCon.Close();  
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
            }
        }



        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conex.Open();   
            SqlCommand cmd = new SqlCommand("delete from productos where Id_producto=@ID", conex);
            cmd.Parameters.AddWithValue("@ID", textID.Text);
            cmd.ExecuteNonQuery();

            Poblar();


            conex.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Poblar();
        }
    }
}






