namespace ADMINISTRADORES
{
    partial class FmInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmInscripcion));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNcarnet = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.PnlLinea = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DtaInscripcion = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtaInscripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(87, 42);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(328, 33);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "BOLETA DE INSCRIPCION";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // LblNcarnet
            // 
            this.LblNcarnet.AutoSize = true;
            this.LblNcarnet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNcarnet.ForeColor = System.Drawing.Color.White;
            this.LblNcarnet.Location = new System.Drawing.Point(325, 150);
            this.LblNcarnet.Name = "LblNcarnet";
            this.LblNcarnet.Size = new System.Drawing.Size(192, 22);
            this.LblNcarnet.TabIndex = 1;
            this.LblNcarnet.Text = "NUMERO DE CARNÉ\r\n";
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNumero.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.ForeColor = System.Drawing.Color.White;
            this.TxtNumero.Location = new System.Drawing.Point(531, 145);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(200, 24);
            this.TxtNumero.TabIndex = 2;
            this.TxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNumero.TextChanged += new System.EventHandler(this.TxtNumero_TextChanged);
            // 
            // PnlLinea
            // 
            this.PnlLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(55)))), ((int)(((byte)(35)))));
            this.PnlLinea.Location = new System.Drawing.Point(531, 171);
            this.PnlLinea.Name = "PnlLinea";
            this.PnlLinea.Size = new System.Drawing.Size(200, 1);
            this.PnlLinea.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(970, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 105);
            this.button1.TabIndex = 31;
            this.button1.Text = "VISUALIZAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DtaInscripcion
            // 
            this.DtaInscripcion.AllowUserToOrderColumns = true;
            this.DtaInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtaInscripcion.Location = new System.Drawing.Point(232, 276);
            this.DtaInscripcion.Name = "DtaInscripcion";
            this.DtaInscripcion.Size = new System.Drawing.Size(840, 237);
            this.DtaInscripcion.TabIndex = 32;
            this.DtaInscripcion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaInscripcion_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(1126, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 105);
            this.button2.TabIndex = 33;
            this.button2.Text = "TRASLADAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // FmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1284, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DtaInscripcion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PnlLinea);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblNcarnet);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.DtaInscripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblTitulo;
        public System.Windows.Forms.Label LblNcarnet;
        public System.Windows.Forms.TextBox TxtNumero;
        public System.Windows.Forms.Panel PnlLinea;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView DtaInscripcion;
        public System.Windows.Forms.Button button2;
    }
}