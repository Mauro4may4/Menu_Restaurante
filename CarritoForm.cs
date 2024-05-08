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

namespace Menu_Restaurante
{
    public partial class CarritoForm : Form
    {
        private OleDbDataAdapter da;
        private DataSet ds;

        public CarritoForm()
        {
            InitializeComponent();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content clicks if needed (code removed for brevity)
        }
        SqlConnection conex = new SqlConnection("Data Source = restaurantssq.database.windows.net; Initial Catalog = Restaurant; Persist Security Info = True; User ID = Toto28; Password = Toto2323; TrustServerCertificate = True");
        OleDbConnection oleCon = new OleDbConnection("Provider=SQLOLEDB;Data Source=restaurantssq.database.windows.net;Initial Catalog=Restaurant;Persist Security Info=True;User ID=Toto28;Password=Toto2323;");

        public void Poblar()
        {
            oleCon.Open();  
            da = new OleDbDataAdapter("select ID,ID_PRODUCTO,DESCRIPCION,PRECIO,CANTIDAD, from detalles_combo", oleCon);
            ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                ComboForm2.AutoGenerateColumns = false;
                ComboForm2.DataSource = ds.Tables[0];
            }
            else
            {
                ComboForm2.DataSource = null;
            }
            oleCon.Close();
        }
        private void ComboForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
