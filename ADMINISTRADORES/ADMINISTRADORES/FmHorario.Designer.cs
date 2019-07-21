namespace ADMINISTRADORES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmHorario));
            this.TxtCarnet = new System.Windows.Forms.TextBox();
            this.PnlSeparador1 = new System.Windows.Forms.Panel();
            this.PnlSeparador2 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CboSemestre = new System.Windows.Forms.ComboBox();
            this.LblTituloHorario = new System.Windows.Forms.Label();
            this.LblTituloSemestre = new System.Windows.Forms.Label();
            this.LblTituloCarnet = new System.Windows.Forms.Label();
            this.DgvHorario = new System.Windows.Forms.DataGridView();
            this.BtnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCarnet
            // 
            this.TxtCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TxtCarnet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCarnet.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarnet.ForeColor = System.Drawing.Color.White;
            this.TxtCarnet.Location = new System.Drawing.Point(72, 40);
            this.TxtCarnet.Name = "TxtCarnet";
            this.TxtCarnet.Size = new System.Drawing.Size(180, 18);
            this.TxtCarnet.TabIndex = 0;
            this.TxtCarnet.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // PnlSeparador1
            // 
            this.PnlSeparador1.BackColor = System.Drawing.Color.Red;
            this.PnlSeparador1.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparador1.Location = new System.Drawing.Point(65, 64);
            this.PnlSeparador1.Name = "PnlSeparador1";
            this.PnlSeparador1.Size = new System.Drawing.Size(200, 1);
            this.PnlSeparador1.TabIndex = 1;
            // 
            // PnlSeparador2
            // 
            this.PnlSeparador2.BackColor = System.Drawing.Color.Red;
            this.PnlSeparador2.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparador2.Location = new System.Drawing.Point(21, 111);
            this.PnlSeparador2.Name = "PnlSeparador2";
            this.PnlSeparador2.Size = new System.Drawing.Size(752, 1);
            this.PnlSeparador2.TabIndex = 2;
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
            this.BtnBuscar.Location = new System.Drawing.Point(616, 17);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 57);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.Button1_Click);
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
            this.CboSemestre.Location = new System.Drawing.Point(376, 40);
            this.CboSemestre.Name = "CboSemestre";
            this.CboSemestre.Size = new System.Drawing.Size(150, 25);
            this.CboSemestre.TabIndex = 4;
            // 
            // LblTituloHorario
            // 
            this.LblTituloHorario.AutoSize = true;
            this.LblTituloHorario.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloHorario.ForeColor = System.Drawing.Color.White;
            this.LblTituloHorario.Location = new System.Drawing.Point(33, 83);
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
            this.LblTituloSemestre.Location = new System.Drawing.Point(402, 17);
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
            this.LblTituloCarnet.Location = new System.Drawing.Point(78, 17);
            this.LblTituloCarnet.Name = "LblTituloCarnet";
            this.LblTituloCarnet.Size = new System.Drawing.Size(60, 20);
            this.LblTituloCarnet.TabIndex = 7;
            this.LblTituloCarnet.Text = "Carnet";
            // 
            // DgvHorario
            // 
            this.DgvHorario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.DgvHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHorario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvHorario.GridColor = System.Drawing.Color.Black;
            this.DgvHorario.Location = new System.Drawing.Point(38, 142);
            this.DgvHorario.Name = "DgvHorario";
            this.DgvHorario.Size = new System.Drawing.Size(716, 150);
            this.DgvHorario.TabIndex = 8;
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
            this.BtnExportar.Location = new System.Drawing.Point(697, 17);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(75, 57);
            this.BtnExportar.TabIndex = 9;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExportar.UseVisualStyleBackColor = true;
            // 
            // Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 340);
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
            this.Name = "Horario";
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