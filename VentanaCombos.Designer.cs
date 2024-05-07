namespace Menu_Restaurante
{
    partial class VentanaCombos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComboForm = new System.Windows.Forms.DataGridView();
            this.restaurantDataSet = new Menu_Restaurante.RestaurantDataSet();
            this.restaurantDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Menu_Restaurante.RestaurantDataSetTableAdapters.ProductosTableAdapter();
            this.restaurantDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECCIONAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ComboForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboForm
            // 
            this.ComboForm.AllowUserToAddRows = false;
            this.ComboForm.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ComboForm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ComboForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ComboForm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ComboForm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ComboForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComboForm.ColumnHeadersVisible = false;
            this.ComboForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IMAGEN,
            this.DESCRIPCION,
            this.PRECIO,
            this.CANTIDAD,
            this.SELECCIONAR});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ComboForm.DefaultCellStyle = dataGridViewCellStyle6;
            this.ComboForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboForm.Location = new System.Drawing.Point(0, 0);
            this.ComboForm.Name = "ComboForm";
            this.ComboForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboForm.RowHeadersVisible = false;
            this.ComboForm.RowHeadersWidth = 51;
            this.ComboForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComboForm.Size = new System.Drawing.Size(800, 450);
            this.ComboForm.TabIndex = 0;
            this.ComboForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantDataSetBindingSource
            // 
            this.restaurantDataSetBindingSource.DataSource = this.restaurantDataSet;
            this.restaurantDataSetBindingSource.Position = 0;
            // 
            // restaurantDataSetBindingSource1
            // 
            this.restaurantDataSetBindingSource1.DataSource = this.restaurantDataSet;
            this.restaurantDataSetBindingSource1.Position = 0;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.restaurantDataSetBindingSource;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantDataSetBindingSource2
            // 
            this.restaurantDataSetBindingSource2.DataSource = this.restaurantDataSet;
            this.restaurantDataSetBindingSource2.Position = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // IMAGEN
            // 
            this.IMAGEN.DataPropertyName = "imagen";
            this.IMAGEN.HeaderText = "IMAGEN";
            this.IMAGEN.MinimumWidth = 6;
            this.IMAGEN.Name = "IMAGEN";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "descripcion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DESCRIPCION.DefaultCellStyle = dataGridViewCellStyle3;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.MinimumWidth = 6;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "precio";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle4;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.MinimumWidth = 6;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRECIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "cantidad";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle5;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.MinimumWidth = 6;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CANTIDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SELECCIONAR
            // 
            this.SELECCIONAR.DataPropertyName = "seleccionar";
            this.SELECCIONAR.HeaderText = "SELECCIONAR";
            this.SELECCIONAR.MinimumWidth = 6;
            this.SELECCIONAR.Name = "SELECCIONAR";
            this.SELECCIONAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // VentanaCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ComboForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaCombos";
            this.Load += new System.EventHandler(this.VentanaCombos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComboForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ComboForm;
        private System.Windows.Forms.BindingSource restaurantDataSetBindingSource;
        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource restaurantDataSetBindingSource1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private RestaurantDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource restaurantDataSetBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn IMAGEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECCIONAR;
    }
}