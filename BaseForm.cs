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
        private OleDbDataAdapter da;
        private OleDbConnection oleCon = new OleDbConnection("Provider=SQLOLEDB;Data Source=restaurantssq.database.windows.net;Initial Catalog=Restaurant;Persist Security Info=True;User ID=Toto28;Password=Toto2323;");
        private TicketForm miTicket;
        public DataGridView dataGridView1 = new DataGridView();
        private const string connectionString = @"Data Source = restaurantssq.database.windows.net; Initial Catalog = Restaurant; Persist Security Info = True; User ID = Toto28; Password = Toto2323; TrustServerCertificate = True";
        public BaseForm()
        {
            InitializeComponent();

            miTicket = new TicketForm();
            


        }

        private void label11_Click(object sender, EventArgs e)
{
    // Aquí puedes agregar la lógica que deseas ejecutar cuando se haga clic en el label11
    // Por ejemplo:
    MessageBox.Show("¡Se hizo clic en el label11!");
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

            AbrirFormHijo(new VentanaBebidas());

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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            var otherForms = Application.OpenForms.Cast<Form>()
   .Where(f => f != this) // Exclude the current form
   .ToList();

            AbrirFormHijo(new ventaPostres());


            if (otherForms.Any()) // Check if there are any child forms to close
            {
                otherForms.ForEach(form => form.Close());
            }

            // Ensure ventanaCombos is initialized before using it
            if (ventanaCombos != null)
            {
                ventanaCombos.MdiParent = this;
                PanelPrincipal.Controls.Add(ventanaCombos);
                ventanaCombos.Categoria = "Postres";
                ventanaCombos.Show();
                ventanaCombos.WindowState = FormWindowState.Maximized;


            }
            else
            {

            }



        }

        //Ajustes
        private void button4_Click(object sender, EventArgs e)
        {
            //generamos instancia a BaseForm
            FormPrincipal fp = new FormPrincipal();
            fp.ShowDialog();
        }

        private VentanaComidas ventanaComidas;
        private VentanaCombos ventanaCombos;
        private CarritoForm carritoForm;
        private CarritoForm cr;

        private void baseForm_Resize(object sender, EventArgs e)
        {
            InitializeComponent();

            cr = new CarritoForm();
            cr.ShowDialog();
            carritoForm = new CarritoForm();
            carritoForm.Show();
            carritoForm.WindowState = FormWindowState.Maximized; 

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

        
        public void CalculaTotal()
        {
            // Crear una instancia de OleDbDataAdapter y DataSet
            OleDbDataAdapter da = new OleDbDataAdapter("select * from detalles_combo", conex);
            DataSet ds = new DataSet();

            // Llenar el DataSet con los datos del adaptador
            da.Fill(ds);

            // Inicializar el texto de lbTOTAL
            Total.Text = "0";

            // Verificar si el DataSet tiene alguna fila
            if (ds.Tables[0].Rows.Count > 0)
            {
                // Iterar a través de las filas del DataSet
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    // Sumar al total el producto de cantidad y precio de cada fila
                    Total.Text = (Convert.ToDouble(Total.Text) + (Convert.ToDouble(fila["cantidad"]) * Convert.ToDouble(fila["precio"]))).ToString();
                }
            }

            // Formatear el texto de lbTOTAL con el formato "standard"
            Total.Text = Convert.ToDouble(Total.Text).ToString("N");

        }



        OleDbConnection conex = new OleDbConnection("Provider=SQLOLEDB;Data Source=restaurantssq.database.windows.net;Initial Catalog=Restaurant;Persist Security Info=True;User ID=Toto28;Password=Toto2323;");
        public void BotonAgregar_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conex = new OleDbConnection("Provider=SQLOLEDB;Data Source=restaurantssq.database.windows.net;Initial Catalog=Restaurant;Persist Security Info=True;User ID=Toto28;Password=Toto2323;"))
            {

                int totalFilasAgregadas = 0;
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    int id = dataGridView1.Rows[i].Cells[0].Value.ToString() == string.Empty ? 0 : int.Parse((dataGridView1.Rows[i].Cells[0].Value.ToString()));
                    string descripcion = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    int cantidad = dataGridView1.Rows[i].Cells[2].Value.ToString() == string.Empty ? 0 : int.Parse((dataGridView1.Rows[i].Cells[0].Value.ToString()));
                    int precio = dataGridView1.Rows[i].Cells[3].Value.ToString() == string.Empty ? 0 : int.Parse((dataGridView1.Rows[i].Cells[0].Value.ToString()));
                    
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        conex.Open();
                        SqlCommand verificar = new SqlCommand("Select id from usuario where id=@id", connection);

                        verificar.Parameters.AddWithValue("@id", id);
                        object filasRegresadas = verificar.ExecuteScalar();

                        if (filasRegresadas == null)
                        {
                            SqlCommand cmd = new SqlCommand("INSERT into detalles_combo (descripcion, Cantidad, Precio) VALUES (@descripcion, @cantidad, @precio)",connection);
                            cmd.Parameters.AddWithValue("@descripcion", descripcion);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@precio", precio);
                            int filasAgregadas = cmd.ExecuteNonQuery();
                            totalFilasAgregadas++;
                        }
                    }
                }
                MessageBox.Show($"Filas añadidas:{totalFilasAgregadas}", "Mensaje!!");
                totalFilasAgregadas = 0;
                // Iterar sobre todas las ventanas abiertas
                //foreach (Form form in Application.OpenForms)
                //{
                //    // Verificar si el formulario actual tiene un DataGridView
                //    if (form is VentanaComidas || form is ventaPostres || form is VentanaBebidas || form is VentanaCombos)
                //    {
                //        DataGridView dataGridView = ((DataGridView)form.Controls["dataGridView1"]);

                //        // Verificar si se encuentra el DataGridView en el formulario actual
                //        if (dataGridView != null)
                //        {
                //            // Iterar sobre las filas seleccionadas del DataGridView
                //            foreach (DataGridViewRow fila in dataGridView.Rows)
                //            {
                //                // Verificar si la fila está seleccionada
                //                if (fila.Selected)
                //                {
                //                    // Obtener los valores de las celdas de la fila seleccionada
                                  
                //                    string descripcion = fila.Cells["DESCRIPCION"].Value.ToString();
                //                    double precio = Convert.ToDouble(fila.Cells["PRECIO"].Value);
                //                    int cantidad = Convert.ToInt32(fila.Cells["CANTIDAD"].Value);

                //                    // Insertar los valores en la tabla detalles_combo
                //                    string query = "INSERT into detalles_combo (descripcion, Cantidad, Precio) VALUES (@descripcion, @cantidad, @precio)";
                //                    using (OleDbCommand cmd = new OleDbCommand(query, conex))
                //                    {
                                       
                //                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                //                        cmd.Parameters.AddWithValue("@cantidad", cantidad);
                //                        cmd.Parameters.AddWithValue("@precio", precio);

                //                        cmd.ExecuteNonQuery();
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}

                CalculaTotal();
            }
           
            // Cerrar los formularios excepto el formulario actual
            foreach (Form form in Application.OpenForms.Cast<Form>().Except(new Form[] { this }).ToList())
            {
                form.Close();
            }

            // Crear e inicializar carritoForm
            carritoForm = new CarritoForm();
            carritoForm.MdiParent = this;
            carritoForm.WindowState = FormWindowState.Maximized;
            PanelPrincipal.Controls.Add(carritoForm);
            carritoForm.Show();

        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormHijo(new VentanaComidas());
        }

        public void Total_Click(object sender, EventArgs e)
        {

        }

        private void BotonCompletar_Click(object sender, EventArgs e)
        {
            TicketForm tk = new TicketForm();
            tk.ShowDialog();
            tk.Show();
        }
    }

}
        
    

