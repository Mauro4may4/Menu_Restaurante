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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComboForm = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECCIONAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ComboForm)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.ComboForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboForm.Location = new System.Drawing.Point(0, 0);
            this.ComboForm.Name = "ComboForm";
            this.ComboForm.ReadOnly = true;
            this.ComboForm.RowHeadersVisible = false;
            this.ComboForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComboForm.Size = new System.Drawing.Size(800, 450);
            this.ComboForm.TabIndex = 0;
            this.ComboForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(229, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 147);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrar";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // IMAGEN
            // 
            this.IMAGEN.DataPropertyName = "imagen";
            this.IMAGEN.HeaderText = "IMAGEN";
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "descripcion";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
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
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
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
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CANTIDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SELECCIONAR
            // 
            this.SELECCIONAR.DataPropertyName = "seleccionar";
            this.SELECCIONAR.HeaderText = "SELECCIONAR";
            this.SELECCIONAR.Name = "SELECCIONAR";
            this.SELECCIONAR.ReadOnly = true;
            this.SELECCIONAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // VentanaCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ComboForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaCombos";
            ((System.ComponentModel.ISupportInitialize)(this.ComboForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ComboForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn IMAGEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECCIONAR;
    }
}