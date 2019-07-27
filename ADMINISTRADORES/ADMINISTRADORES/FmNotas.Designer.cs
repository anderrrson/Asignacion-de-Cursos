namespace ADMINISTRADORES
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
            this.label2 = new System.Windows.Forms.Label();
            this.LblNotas = new System.Windows.Forms.Label();
            this.CboSemestre = new System.Windows.Forms.ComboBox();
            this.PnlSeparador2 = new System.Windows.Forms.Panel();
            this.LblAño = new System.Windows.Forms.Label();
            this.CboAño = new System.Windows.Forms.ComboBox();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblTituloCarnet = new System.Windows.Forms.Label();
            this.PnlSeparador1 = new System.Windows.Forms.Panel();
            this.TxtCarnet = new System.Windows.Forms.TextBox();
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
            this.DgvNotas.Location = new System.Drawing.Point(39, 190);
            this.DgvNotas.Name = "DgvNotas";
            this.DgvNotas.Size = new System.Drawing.Size(1220, 150);
            this.DgvNotas.TabIndex = 18;
            this.DgvNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaHorario_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(355, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Semestre";
            // 
            // LblNotas
            // 
            this.LblNotas.AutoSize = true;
            this.LblNotas.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNotas.ForeColor = System.Drawing.Color.White;
            this.LblNotas.Location = new System.Drawing.Point(34, 131);
            this.LblNotas.Name = "LblNotas";
            this.LblNotas.Size = new System.Drawing.Size(74, 25);
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
            this.CboSemestre.Location = new System.Drawing.Point(338, 71);
            this.CboSemestre.Name = "CboSemestre";
            this.CboSemestre.Size = new System.Drawing.Size(188, 25);
            this.CboSemestre.TabIndex = 14;
            // 
            // PnlSeparador2
            // 
            this.PnlSeparador2.BackColor = System.Drawing.Color.Red;
            this.PnlSeparador2.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparador2.Location = new System.Drawing.Point(22, 159);
            this.PnlSeparador2.Name = "PnlSeparador2";
            this.PnlSeparador2.Size = new System.Drawing.Size(1260, 1);
            this.PnlSeparador2.TabIndex = 12;
            // 
            // LblAño
            // 
            this.LblAño.AutoSize = true;
            this.LblAño.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAño.ForeColor = System.Drawing.Color.White;
            this.LblAño.Location = new System.Drawing.Point(577, 40);
            this.LblAño.Name = "LblAño";
            this.LblAño.Size = new System.Drawing.Size(39, 20);
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
            this.CboAño.Location = new System.Drawing.Point(562, 71);
            this.CboAño.Name = "CboAño";
            this.CboAño.Size = new System.Drawing.Size(150, 25);
            this.CboAño.TabIndex = 20;
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
            this.BtnExportar.Location = new System.Drawing.Point(1031, 55);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnExportar.Size = new System.Drawing.Size(148, 41);
            this.BtnExportar.TabIndex = 23;
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
            this.BtnBuscar.Location = new System.Drawing.Point(847, 55);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnBuscar.Size = new System.Drawing.Size(148, 41);
            this.BtnBuscar.TabIndex = 22;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblTituloCarnet
            // 
            this.LblTituloCarnet.AutoSize = true;
            this.LblTituloCarnet.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCarnet.ForeColor = System.Drawing.Color.White;
            this.LblTituloCarnet.Location = new System.Drawing.Point(92, 40);
            this.LblTituloCarnet.Name = "LblTituloCarnet";
            this.LblTituloCarnet.Size = new System.Drawing.Size(60, 20);
            this.LblTituloCarnet.TabIndex = 26;
            this.LblTituloCarnet.Text = "Carnet";
            // 
            // PnlSeparador1
            // 
            this.PnlSeparador1.BackColor = System.Drawing.Color.Red;
            this.PnlSeparador1.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparador1.Location = new System.Drawing.Point(87, 95);
            this.PnlSeparador1.Name = "PnlSeparador1";
            this.PnlSeparador1.Size = new System.Drawing.Size(200, 1);
            this.PnlSeparador1.TabIndex = 25;
            // 
            // TxtCarnet
            // 
            this.TxtCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TxtCarnet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCarnet.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarnet.ForeColor = System.Drawing.Color.White;
            this.TxtCarnet.Location = new System.Drawing.Point(87, 63);
            this.TxtCarnet.Name = "TxtCarnet";
            this.TxtCarnet.Size = new System.Drawing.Size(180, 26);
            this.TxtCarnet.TabIndex = 24;
            // 
            // FmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1300, 571);
            this.Controls.Add(this.LblTituloCarnet);
            this.Controls.Add(this.PnlSeparador1);
            this.Controls.Add(this.TxtCarnet);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.LblAño);
            this.Controls.Add(this.CboAño);
            this.Controls.Add(this.DgvNotas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblNotas);
            this.Controls.Add(this.CboSemestre);
            this.Controls.Add(this.PnlSeparador2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvNotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNotas;
        private System.Windows.Forms.ComboBox CboSemestre;
        private System.Windows.Forms.Panel PnlSeparador2;
        private System.Windows.Forms.Label LblAño;
        private System.Windows.Forms.ComboBox CboAño;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblTituloCarnet;
        private System.Windows.Forms.Panel PnlSeparador1;
        private System.Windows.Forms.TextBox TxtCarnet;
    }
}