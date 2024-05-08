namespace Menu_Restaurante
{
    partial class VentaComidas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaComidas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComboForm = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta_Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECCIONAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ComboForm)).BeginInit();
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
            this.ComboForm.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ComboForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComboForm.ColumnHeadersVisible = false;
            this.ComboForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ruta_Imagen,
            this.DESCRIPCION,
            this.PRECIO,
            this.CANTIDAD,
            this.SELECCIONAR});
            this.ComboForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboForm.Location = new System.Drawing.Point(0, 0);
            this.ComboForm.Margin = new System.Windows.Forms.Padding(4);
            this.ComboForm.Name = "ComboForm";
            this.ComboForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboForm.RowHeadersVisible = false;
            this.ComboForm.RowHeadersWidth = 51;
            this.ComboForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComboForm.Size = new System.Drawing.Size(1011, 533);
            this.ComboForm.TabIndex = 1;
            this.ComboForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComboForm_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Ruta_Imagen
            // 
            this.Ruta_Imagen.DataPropertyName = "Imagen";
            this.Ruta_Imagen.HeaderText = "IMAGEN";
            this.Ruta_Imagen.Image = ((System.Drawing.Image)(resources.GetObject("Ruta_Imagen.Image")));
            this.Ruta_Imagen.MinimumWidth = 6;
            this.Ruta_Imagen.Name = "Ruta_Imagen";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "descripcion";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.MinimumWidth = 6;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "precio";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.MinimumWidth = 6;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRECIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "cantidad";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle3;
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
            // VentaComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 533);
            this.ControlBox = false;
            this.Controls.Add(this.ComboForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentaComidas";
            this.Text = "VentaComidas";
            ((System.ComponentModel.ISupportInitialize)(this.ComboForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ComboForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn Ruta_Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECCIONAR;
    }
}