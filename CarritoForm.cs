using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Menu_Restaurante
{
    public partial class CarritoForm : Form
    {
        private OleDbDataAdapter da;
        private DataSet ds;
        private OleDbConnection oleCon = new OleDbConnection("Provider=SQLOLEDB;Data Source=restaurantssq.database.windows.net;Initial Catalog=Restaurant;Persist Security Info=True;User ID=Toto28;Password=Toto2323;");

        public CarritoForm()
        {
            InitializeComponent();
        }

        public void Poblar()
        {
            oleCon.Open();
            da = new OleDbDataAdapter("select ID,ID_PRODUCTO,DESCRIPCION,PRECIO,CANTIDAD from detalles_combo", oleCon);
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
            // Handle cell content clicks if needed (code removed for brevity)
        }


        private void CarritoForm_VisibleChanged_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in ComboForm2.Rows)
            {
                oleCon.Open();
                da = new OleDbDataAdapter("select * from detalles_combo where id_producto=" + fila.Cells["ID_PRODUCTO"].Value, oleCon);
                ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                   
                }
                oleCon.Close();
            }
        }

        private void ComboForm2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (ComboForm2.Rows.Count > 0)
            {
                if (ComboForm2.CurrentRow.Cells["CANTIDAD"].Value != null)
                {
                    OleDbCommand cmd = new OleDbCommand("update detalles_combo set cantidad='" + ComboForm2.CurrentCell.Value + "' where id=" + ComboForm2.CurrentRow.Cells["ID"].Value, oleCon);
                    oleCon.Open();
                    cmd.ExecuteNonQuery();
                    oleCon.Close();
                }


            }
        }

        private void CarritoForm_Load(object sender, EventArgs e)
        {
            Poblar();
        }
    }
}
