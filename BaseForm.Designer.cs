﻿using System;

namespace Menu_Restaurante
{
    partial class BaseForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BotonCombos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Total = new System.Windows.Forms.Label();
            this.LbTotal = new System.Windows.Forms.Label();
            this.BotonCompletar = new System.Windows.Forms.Button();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelSuperior.Controls.Add(this.button4);
            this.PanelSuperior.Controls.Add(this.label2);
            this.PanelSuperior.Controls.Add(this.label1);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(993, 63);
            this.PanelSuperior.TabIndex = 2;
            this.PanelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(2)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(937, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 63);
            this.button4.TabIndex = 9;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(517, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restaurant";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eggscellent ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.BotonCombos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 450);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // button1
            // 
            this.button1.AccessibleName = "a";
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(11, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 70);
            this.button1.TabIndex = 9;
            this.button1.Text = "    Comidas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(11, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 74);
            this.button3.TabIndex = 8;
            this.button3.Text = "    Postres";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(11, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 74);
            this.button2.TabIndex = 7;
            this.button2.Text = "    Bebidas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BotonCombos
            // 
            this.BotonCombos.AccessibleName = "a";
            this.BotonCombos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BotonCombos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCombos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BotonCombos.FlatAppearance.BorderSize = 0;
            this.BotonCombos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCombos.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCombos.ForeColor = System.Drawing.Color.White;
            this.BotonCombos.Image = ((System.Drawing.Image)(resources.GetObject("BotonCombos.Image")));
            this.BotonCombos.Location = new System.Drawing.Point(12, 151);
            this.BotonCombos.Name = "BotonCombos";
            this.BotonCombos.Size = new System.Drawing.Size(193, 70);
            this.BotonCombos.TabIndex = 5;
            this.BotonCombos.Text = "    Combos";
            this.BotonCombos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonCombos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonCombos.UseVisualStyleBackColor = true;
            this.BotonCombos.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.Total);
            this.panel2.Controls.Add(this.LbTotal);
            this.panel2.Controls.Add(this.BotonCompletar);
            this.panel2.Controls.Add(this.BotonAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(215, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 57);
            this.panel2.TabIndex = 4;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.Black;
            this.Total.Location = new System.Drawing.Point(129, 20);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(18, 19);
            this.Total.TabIndex = 4;
            this.Total.Text = "0";
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // LbTotal
            // 
            this.LbTotal.AutoSize = true;
            this.LbTotal.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotal.ForeColor = System.Drawing.Color.Black;
            this.LbTotal.Location = new System.Drawing.Point(6, 20);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(126, 19);
            this.LbTotal.TabIndex = 3;
            this.LbTotal.Text = "Total en carrito:";
            // 
            // BotonCompletar
            // 
            this.BotonCompletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCompletar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BotonCompletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCompletar.FlatAppearance.BorderSize = 2;
            this.BotonCompletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCompletar.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCompletar.ForeColor = System.Drawing.Color.White;
            this.BotonCompletar.Image = ((System.Drawing.Image)(resources.GetObject("BotonCompletar.Image")));
            this.BotonCompletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonCompletar.Location = new System.Drawing.Point(395, 6);
            this.BotonCompletar.Name = "BotonCompletar";
            this.BotonCompletar.Size = new System.Drawing.Size(185, 48);
            this.BotonCompletar.TabIndex = 1;
            this.BotonCompletar.Text = " Completar Compra";
            this.BotonCompletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonCompletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonCompletar.UseVisualStyleBackColor = false;
            this.BotonCompletar.Click += new System.EventHandler(this.BotonCompletar_Click);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonAgregar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BotonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAgregar.FlatAppearance.BorderSize = 2;
            this.BotonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAgregar.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregar.ForeColor = System.Drawing.Color.White;
            this.BotonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BotonAgregar.Image")));
            this.BotonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonAgregar.Location = new System.Drawing.Point(586, 6);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(185, 48);
            this.BotonAgregar.TabIndex = 0;
            this.BotonAgregar.Text = "  Agregar al carro";
            this.BotonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(215, 63);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(778, 393);
            this.PanelPrincipal.TabIndex = 5;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 513);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelSuperior);
            this.IsMdiContainer = true;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BotonCombos;
        private System.Windows.Forms.Button BotonCompletar;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label Total;
    }
}

