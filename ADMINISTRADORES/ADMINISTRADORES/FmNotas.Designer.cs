﻿namespace ADMINISTRADORES
{
    partial class FmNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmNotas));
            this.DgvNotas = new System.Windows.Forms.DataGridView();
            this.LblCarnet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNotas = new System.Windows.Forms.Label();
            this.CboSemestre = new System.Windows.Forms.ComboBox();
            this.PnlSeparador2 = new System.Windows.Forms.Panel();
            this.PnlSeparador1 = new System.Windows.Forms.Panel();
            this.TxtCarnet = new System.Windows.Forms.TextBox();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblAño = new System.Windows.Forms.Label();
            this.CboAño = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvNotas
            // 
            this.DgvNotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.DgvNotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvNotas.GridColor = System.Drawing.Color.Black;
            this.DgvNotas.Location = new System.Drawing.Point(51, 181);
            this.DgvNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvNotas.Name = "DgvNotas";
            this.DgvNotas.Size = new System.Drawing.Size(955, 185);
            this.DgvNotas.TabIndex = 18;
            this.DgvNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaHorario_CellContentClick);
            // 
            // LblCarnet
            // 
            this.LblCarnet.AutoSize = true;
            this.LblCarnet.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarnet.ForeColor = System.Drawing.Color.White;
            this.LblCarnet.Location = new System.Drawing.Point(104, 27);
            this.LblCarnet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCarnet.Name = "LblCarnet";
            this.LblCarnet.Size = new System.Drawing.Size(75, 22);
            this.LblCarnet.TabIndex = 17;
            this.LblCarnet.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(413, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Semestre";
            // 
            // LblNotas
            // 
            this.LblNotas.AutoSize = true;
            this.LblNotas.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNotas.ForeColor = System.Drawing.Color.White;
            this.LblNotas.Location = new System.Drawing.Point(44, 108);
            this.LblNotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNotas.Name = "LblNotas";
            this.LblNotas.Size = new System.Drawing.Size(91, 33);
            this.LblNotas.TabIndex = 15;
            this.LblNotas.Text = "Notas";
            // 
            // CboSemestre
            // 
            this.CboSemestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.CboSemestre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSemestre.ForeColor = System.Drawing.Color.White;
            this.CboSemestre.FormattingEnabled = true;
            this.CboSemestre.Items.AddRange(new object[] {
            "1° Semestre",
            "2° Semestre"});
            this.CboSemestre.Location = new System.Drawing.Point(379, 55);
            this.CboSemestre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboSemestre.Name = "CboSemestre";
            this.CboSemestre.Size = new System.Drawing.Size(199, 29);
            this.CboSemestre.TabIndex = 14;
            // 
            // PnlSeparador2
            // 
            this.PnlSeparador2.BackColor = System.Drawing.Color.Red;
            this.PnlSeparador2.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparador2.Location = new System.Drawing.Point(28, 143);
            this.PnlSeparador2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlSeparador2.Name = "PnlSeparador2";
            this.PnlSeparador2.Size = new System.Drawing.Size(1003, 1);
            this.PnlSeparador2.TabIndex = 12;
            // 
            // PnlSeparador1
            // 
            this.PnlSeparador1.BackColor = System.Drawing.Color.Red;
            this.PnlSeparador1.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparador1.Location = new System.Drawing.Point(87, 85);
            this.PnlSeparador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlSeparador1.Name = "PnlSeparador1";
            this.PnlSeparador1.Size = new System.Drawing.Size(267, 1);
            this.PnlSeparador1.TabIndex = 11;
            // 
            // TxtCarnet
            // 
            this.TxtCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TxtCarnet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCarnet.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarnet.ForeColor = System.Drawing.Color.White;
            this.TxtCarnet.Location = new System.Drawing.Point(96, 55);
            this.TxtCarnet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCarnet.Name = "TxtCarnet";
            this.TxtCarnet.Size = new System.Drawing.Size(240, 23);
            this.TxtCarnet.TabIndex = 10;
            // 
            // BtnExportar
            // 
            this.BtnExportar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnExportar.FlatAppearance.BorderSize = 2;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportar.ForeColor = System.Drawing.Color.White;
            this.BtnExportar.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportar.Image")));
            this.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnExportar.Location = new System.Drawing.Point(929, 27);
            this.BtnExportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(100, 70);
            this.BtnExportar.TabIndex = 19;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExportar.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnBuscar.FlatAppearance.BorderSize = 2;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(821, 27);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 70);
            this.BtnBuscar.TabIndex = 13;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LblAño
            // 
            this.LblAño.AutoSize = true;
            this.LblAño.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAño.ForeColor = System.Drawing.Color.White;
            this.LblAño.Location = new System.Drawing.Point(633, 27);
            this.LblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAño.Name = "LblAño";
            this.LblAño.Size = new System.Drawing.Size(49, 22);
            this.LblAño.TabIndex = 21;
            this.LblAño.Text = "Año";
            // 
            // CboAño
            // 
            this.CboAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.CboAño.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboAño.ForeColor = System.Drawing.Color.White;
            this.CboAño.FormattingEnabled = true;
            this.CboAño.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.CboAño.Location = new System.Drawing.Point(599, 55);
            this.CboAño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboAño.Name = "CboAño";
            this.CboAño.Size = new System.Drawing.Size(199, 29);
            this.CboAño.TabIndex = 20;
            // 
            // FmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1067, 404);
            this.Controls.Add(this.LblAño);
            this.Controls.Add(this.CboAño);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.DgvNotas);
            this.Controls.Add(this.LblCarnet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblNotas);
            this.Controls.Add(this.CboSemestre);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.PnlSeparador2);
            this.Controls.Add(this.PnlSeparador1);
            this.Controls.Add(this.TxtCarnet);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.DataGridView DgvNotas;
        private System.Windows.Forms.Label LblCarnet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNotas;
        private System.Windows.Forms.ComboBox CboSemestre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Panel PnlSeparador2;
        private System.Windows.Forms.Panel PnlSeparador1;
        private System.Windows.Forms.TextBox TxtCarnet;
        private System.Windows.Forms.Label LblAño;
        private System.Windows.Forms.ComboBox CboAño;
    }
}