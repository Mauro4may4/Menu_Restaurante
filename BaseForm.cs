using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menu_Restaurante;
using System.Data.OleDb;




namespace Menu_Restaurante
{
    public partial class BaseForm : Form
    {
        conexion conex = new conexion();
        Categorias ct = new Categorias();



        public BaseForm()
        {
            InitializeComponent();




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        //Funcion para llamar objeto
        private void AbrirFormHijo(object formhija)
        {

            //Preguntamos si existe algún control en interior del panel si es verdadero se elimina
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            //Indicamos que no es un formulario de nivel superior
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(fh);
            this.PanelPrincipal.Tag = fh;
            fh.Show();
        }

        //Boton Combos
        public void button1_Click(object sender, EventArgs e)
        {

            var otherForms = Application.OpenForms.Cast<Form>()
   .Where(f => f != this) // Exclude the current form
   .ToList();

            AbrirFormHijo(new VentanaCombos());


            if (otherForms.Any()) // Check if there are any child forms to close
            {
                otherForms.ForEach(form => form.Close());
            }

            // Ensure ventanaCombos is initialized before using it
            if (ventanaCombos != null)
            {
                ventanaCombos.MdiParent = this;
                PanelPrincipal.Controls.Add(ventanaCombos);
                ventanaCombos.Categoria = "Bebidas";
                ventanaCombos.Show();
                ventanaCombos.WindowState = FormWindowState.Maximized;


            }
            else
            {

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {

            var otherForms = Application.OpenForms.Cast<Form>()
   .Where(f => f != this) // Exclude the current form
   .ToList();

            AbrirFormHijo(new VentaComidas());

            if (otherForms.Any()) // Check if there are any child forms to close
            {
                otherForms.ForEach(form => form.Close());
            }

            // Ensure ventanaCombos is initialized before using it
            if (ventanaCombos != null)
            {
                ventanaCombos.MdiParent = this;
                PanelPrincipal.Controls.Add(ventanaCombos);
                ventanaCombos.Categoria = "Bebidas";
                ventanaCombos.Show();
                ventanaCombos.WindowState = FormWindowState.Maximized;



                SqlConnection cn = conex.LeerCadena();
            }
            else
            {

            }

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new VentanaCombos());



        }

        //Ajustes
        private void button4_Click(object sender, EventArgs e)
        {
            //generamos instancia a BaseForm
            FormPrincipal fp = new FormPrincipal();
            fp.ShowDialog();
        }

        private VentanaCombos ventanaCombos;

        private void baseForm_Resize(object sender, EventArgs e)
        {
            InitializeComponent();
            ventanaCombos = new VentanaCombos();
            ventanaCombos.Show();
            ventanaCombos.WindowState = FormWindowState.Maximized;
        }


        private void BotonRemover_Click(object sender, EventArgs e)
        {

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
          /*  SqlConnection conex = new SqlConnection("Data Source = restaurantssq.database.windows.net; Initial Catalog = Restaurant; Persist Security Info = True; User ID = Toto28; Password = Toto2323; TrustServerCertificate = True");
            OleDbConnection oleCon = new OleDbConnection("Provider=SQLOLEDB;Data Source=restaurantssq.database.windows.net;Initial Catalog=Restaurant;Persist Security Info=True;User ID=Toto28;Password=Toto2323;");


            foreach (Form frm in Application.OpenForms)
             {
                 if (frm.Name == "comboForm2")
                 {
                     foreach (DataGridViewRow row in ((CarritoForm)frm).DataGridView1.Rows)
                     {
                         if ((bool)row.Cells["SELECCIONAR"].Value) // Assuming "SELECCIONAR" cell contains a boolean value
                         {
                             string id = row.Cells["ID"].Value.ToString();
                             string descripcion = row.Cells["DESCRIPCION"].Value.ToString();
                             string cantidad = row.Cells["CANTIDAD"].Value?.ToString(); // Handle null value
                             string precio = row.Cells["PRECIO"].Value.ToString();
               

                             OleDbCommand cmd = new OleDbCommand("insert into detalles_combo(id_producto,descripcion,cantidad,precio) values(@id, @descripcion, @cantidad, @precio)", oleCon);
                             cmd.Parameters.AddWithValue("@id", id);
                             cmd.Parameters.AddWithValue("@descripcion", descripcion);
                             cmd.Parameters.AddWithValue("@cantidad", cantidad);
                             cmd.Parameters.AddWithValue("@precio", precio);
                        
                             cmd.ExecuteNonQuery();
                         }
                     }

                     ((CarritoForm)frm).Close();
                     break; // Exit after finding the "comboForm"
                 }
             }

             CalculaTotal();

             // Close all other open forms except the current one (assuming CalculaTotal is defined elsewhere)
             Application.OpenForms.Cast<Form>().Where(form => form != this).ToList().ForEach(form => form.Close());

             Carrito.MdiParent = this;
             PanelPrincipal.Controls.Add(carritoForm);
             carritoForm.Show();
             carritoForm.WindowState = FormWindowState.Maximized; // Set directly to maximized

             lbOpcion.Text = "Carrito";
            */
         }
        }
    }

