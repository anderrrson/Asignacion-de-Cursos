﻿namespace ADMINISTRADORES
{
    partial class FmHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmHorario));
            this.TxtCarnet = new System.Windows.Forms.TextBox();
            this.PnlSeparador1 = new System.Windows.Forms.Panel();
            this.PnlSeparador2 = new System.Windows.Forms.Panel();
            this.CboSemestre = new System.Windows.Forms.ComboBox();
            this.LblTituloHorario = new System.Windows.Forms.Label();
            this.LblTituloSemestre = new System.Windows.Forms.Label();
            this.LblTituloCarnet = new System.Windows.Forms.Label();
            this.DgvHorario = new System.Windows.Forms.DataGridView();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCarnet
            // 
            this.TxtCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TxtCarnet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCarnet.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarnet.ForeColor = System.Drawing.Color.White;
            this.TxtCarnet.Location = new System.Drawing.Point(100, 59);
            this.TxtCarnet.Name = "TxtCarnet";
            this.TxtCarnet.Size = new System.Drawing.Size(180, 26);
            this.TxtCarnet.TabIndex = 0;
            this.TxtCarnet.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // PnlSeparador1
            // 
            this.PnlSeparador1.BackColor = System.Drawing.Color.Red;
            this.PnlSeparador1.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparador1.Location = new System.Drawing.Point(100, 91);
            this.PnlSeparador1.Name = "PnlSeparador1";
            this.PnlSeparador1.Size = new System.Drawing.Size(200, 1);
            this.PnlSeparador1.TabIndex = 1;
            // 
            // PnlSeparador2
            // 
            this.PnlSeparador2.BackColor = System.Drawing.Color.Red;
            this.PnlSeparador2.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparador2.Location = new System.Drawing.Point(21, 156);
            this.PnlSeparador2.Name = "PnlSeparador2";
            this.PnlSeparador2.Size = new System.Drawing.Size(1260, 1);
            this.PnlSeparador2.TabIndex = 2;
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
            this.CboSemestre.Location = new System.Drawing.Point(410, 67);
            this.CboSemestre.Name = "CboSemestre";
            this.CboSemestre.Size = new System.Drawing.Size(214, 25);
            this.CboSemestre.TabIndex = 4;
            // 
            // LblTituloHorario
            // 
            this.LblTituloHorario.AutoSize = true;
            this.LblTituloHorario.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloHorario.ForeColor = System.Drawing.Color.White;
            this.LblTituloHorario.Location = new System.Drawing.Point(33, 128);
            this.LblTituloHorario.Name = "LblTituloHorario";
            this.LblTituloHorario.Size = new System.Drawing.Size(88, 25);
            this.LblTituloHorario.TabIndex = 5;
            this.LblTituloHorario.Text = "Horario";
            // 
            // LblTituloSemestre
            // 
            this.LblTituloSemestre.AutoSize = true;
            this.LblTituloSemestre.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloSemestre.ForeColor = System.Drawing.Color.White;
            this.LblTituloSemestre.Location = new System.Drawing.Point(428, 36);
            this.LblTituloSemestre.Name = "LblTituloSemestre";
            this.LblTituloSemestre.Size = new System.Drawing.Size(75, 20);
            this.LblTituloSemestre.TabIndex = 6;
            this.LblTituloSemestre.Text = "Semestre";
            // 
            // LblTituloCarnet
            // 
            this.LblTituloCarnet.AutoSize = true;
            this.LblTituloCarnet.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCarnet.ForeColor = System.Drawing.Color.White;
            this.LblTituloCarnet.Location = new System.Drawing.Point(105, 36);
            this.LblTituloCarnet.Name = "LblTituloCarnet";
            this.LblTituloCarnet.Size = new System.Drawing.Size(60, 20);
            this.LblTituloCarnet.TabIndex = 7;
            this.LblTituloCarnet.Text = "Carnet";
            // 
            // DgvHorario
            // 
            this.DgvHorario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.DgvHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHorario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvHorario.GridColor = System.Drawing.Color.Black;
            this.DgvHorario.Location = new System.Drawing.Point(38, 190);
            this.DgvHorario.Name = "DgvHorario";
            this.DgvHorario.Size = new System.Drawing.Size(1220, 249);
            this.DgvHorario.TabIndex = 8;
            // 
            // BtnExportar
            // 
            this.BtnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.BtnExportar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExportar.FlatAppearance.BorderSize = 2;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportar.ForeColor = System.Drawing.Color.White;
            this.BtnExportar.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportar.Image")));
            this.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExportar.Location = new System.Drawing.Point(975, 52);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnExportar.Size = new System.Drawing.Size(148, 41);
            this.BtnExportar.TabIndex = 9;
            this.BtnExportar.Text = "   Exportar";
            this.BtnExportar.UseVisualStyleBackColor = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatAppearance.BorderSize = 2;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(791, 52);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnBuscar.Size = new System.Drawing.Size(148, 41);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1300, 571);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.DgvHorario);
            this.Controls.Add(this.LblTituloCarnet);
            this.Controls.Add(this.LblTituloSemestre);
            this.Controls.Add(this.LblTituloHorario);
            this.Controls.Add(this.CboSemestre);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.PnlSeparador2);
            this.Controls.Add(this.PnlSeparador1);
            this.Controls.Add(this.TxtCarnet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmHorario";
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.Horario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCarnet;
        private System.Windows.Forms.Panel PnlSeparador1;
        private System.Windows.Forms.Panel PnlSeparador2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CboSemestre;
        private System.Windows.Forms.Label LblTituloHorario;
        private System.Windows.Forms.Label LblTituloSemestre;
        private System.Windows.Forms.Label LblTituloCarnet;
        private System.Windows.Forms.DataGridView DgvHorario;
        private System.Windows.Forms.Button BtnExportar;
    }
}