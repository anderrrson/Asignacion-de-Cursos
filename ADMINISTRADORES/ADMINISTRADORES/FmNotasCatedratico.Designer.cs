﻿namespace ADMINISTRADORES
{
    partial class FmNotasCatedratico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmNotasCatedratico));
            this.PnlSeparadorCodigoCatedratico = new System.Windows.Forms.Panel();
            this.LblTituloCatedratico = new System.Windows.Forms.Label();
            this.TxtCodigoCatedratico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CboSemestre = new System.Windows.Forms.ComboBox();
            this.LblAño = new System.Windows.Forms.Label();
            this.CboAño = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblNotas = new System.Windows.Forms.Label();
            this.PnlSeparador2 = new System.Windows.Forms.Panel();
            this.DgvNotas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSeparadorCodigoCatedratico
            // 
            this.PnlSeparadorCodigoCatedratico.BackColor = System.Drawing.Color.Red;
            this.PnlSeparadorCodigoCatedratico.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparadorCodigoCatedratico.Location = new System.Drawing.Point(50, 87);
            this.PnlSeparadorCodigoCatedratico.Name = "PnlSeparadorCodigoCatedratico";
            this.PnlSeparadorCodigoCatedratico.Size = new System.Drawing.Size(200, 1);
            this.PnlSeparadorCodigoCatedratico.TabIndex = 19;
            this.PnlSeparadorCodigoCatedratico.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSeparadorCodigoCatedratico_Paint);
            // 
            // LblTituloCatedratico
            // 
            this.LblTituloCatedratico.AutoSize = true;
            this.LblTituloCatedratico.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCatedratico.ForeColor = System.Drawing.Color.White;
            this.LblTituloCatedratico.Location = new System.Drawing.Point(46, 32);
            this.LblTituloCatedratico.Name = "LblTituloCatedratico";
            this.LblTituloCatedratico.Size = new System.Drawing.Size(158, 20);
            this.LblTituloCatedratico.TabIndex = 17;
            this.LblTituloCatedratico.Text = "Codigo Catedrático";
            this.LblTituloCatedratico.Click += new System.EventHandler(this.LblTituloCatedratico_Click);
            // 
            // TxtCodigoCatedratico
            // 
            this.TxtCodigoCatedratico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TxtCodigoCatedratico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCodigoCatedratico.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoCatedratico.ForeColor = System.Drawing.Color.White;
            this.TxtCodigoCatedratico.Location = new System.Drawing.Point(50, 55);
            this.TxtCodigoCatedratico.Name = "TxtCodigoCatedratico";
            this.TxtCodigoCatedratico.Size = new System.Drawing.Size(180, 26);
            this.TxtCodigoCatedratico.TabIndex = 15;
            this.TxtCodigoCatedratico.TextChanged += new System.EventHandler(this.TxtCodigoCatedratico_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(541, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Semestre";
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
            this.CboSemestre.Location = new System.Drawing.Point(524, 63);
            this.CboSemestre.Name = "CboSemestre";
            this.CboSemestre.Size = new System.Drawing.Size(188, 25);
            this.CboSemestre.TabIndex = 21;
            // 
            // LblAño
            // 
            this.LblAño.AutoSize = true;
            this.LblAño.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAño.ForeColor = System.Drawing.Color.White;
            this.LblAño.Location = new System.Drawing.Point(334, 32);
            this.LblAño.Name = "LblAño";
            this.LblAño.Size = new System.Drawing.Size(39, 20);
            this.LblAño.TabIndex = 24;
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
            this.CboAño.Location = new System.Drawing.Point(319, 63);
            this.CboAño.Name = "CboAño";
            this.CboAño.Size = new System.Drawing.Size(150, 25);
            this.CboAño.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(776, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(772, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Codigo Curso";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(776, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 26);
            this.textBox1.TabIndex = 25;
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
            this.BtnBuscar.Location = new System.Drawing.Point(1083, 48);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnBuscar.Size = new System.Drawing.Size(148, 41);
            this.BtnBuscar.TabIndex = 28;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // LblNotas
            // 
            this.LblNotas.AutoSize = true;
            this.LblNotas.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNotas.ForeColor = System.Drawing.Color.White;
            this.LblNotas.Location = new System.Drawing.Point(35, 140);
            this.LblNotas.Name = "LblNotas";
            this.LblNotas.Size = new System.Drawing.Size(74, 25);
            this.LblNotas.TabIndex = 30;
            this.LblNotas.Text = "Notas";
            // 
            // PnlSeparador2
            // 
            this.PnlSeparador2.BackColor = System.Drawing.Color.Red;
            this.PnlSeparador2.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparador2.Location = new System.Drawing.Point(23, 168);
            this.PnlSeparador2.Name = "PnlSeparador2";
            this.PnlSeparador2.Size = new System.Drawing.Size(1260, 1);
            this.PnlSeparador2.TabIndex = 29;
            // 
            // DgvNotas
            // 
            this.DgvNotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.DgvNotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvNotas.GridColor = System.Drawing.Color.Black;
            this.DgvNotas.Location = new System.Drawing.Point(40, 210);
            this.DgvNotas.Name = "DgvNotas";
            this.DgvNotas.Size = new System.Drawing.Size(1220, 150);
            this.DgvNotas.TabIndex = 31;
            this.DgvNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNotas_CellContentClick);
            // 
            // FmNotasCatedratico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1300, 571);
            this.Controls.Add(this.DgvNotas);
            this.Controls.Add(this.LblNotas);
            this.Controls.Add(this.PnlSeparador2);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblAño);
            this.Controls.Add(this.CboAño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboSemestre);
            this.Controls.Add(this.PnlSeparadorCodigoCatedratico);
            this.Controls.Add(this.LblTituloCatedratico);
            this.Controls.Add(this.TxtCodigoCatedratico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmNotasCatedratico";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FmNotasCatedratico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PnlSeparadorCodigoCatedratico;
        private System.Windows.Forms.Label LblTituloCatedratico;
        private System.Windows.Forms.TextBox TxtCodigoCatedratico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboSemestre;
        private System.Windows.Forms.Label LblAño;
        private System.Windows.Forms.ComboBox CboAño;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblNotas;
        private System.Windows.Forms.Panel PnlSeparador2;
        private System.Windows.Forms.DataGridView DgvNotas;
    }
}