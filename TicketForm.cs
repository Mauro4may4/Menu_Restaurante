using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu_Restaurante;


namespace Menu_Restaurante
{
    public partial class TicketForm : Form
    {
        private BaseForm baseform;
       
        public TicketForm()
        {
            InitializeComponent();
       
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {

        }

        OleDbConnection conex = new OleDbConnection("Provider=SQLOLEDB;Data Source=restaurantssq.database.windows.net;Initial Catalog=Restaurant;Persist Security Info=True;User ID=Toto28;Password=Toto2323;");
        public void Poblar()
        {
            BaseForm baseForm = Application.OpenForms.OfType<BaseForm>().FirstOrDefault();
            baseform.Show();

            OleDbDataAdapter da = new OleDbDataAdapter("select id_producto,descripcion,cantidad,precio,(cantidad*precio) as subtotal from detalles_combo group by id_producto,descripcion,cantidad,precio", conex);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];

                label11.Text = baseForm.Total.Text;
            }
        }

        public void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
