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
            this.PicVisualizar = new System.Windows.Forms.PictureBox();
            this.LblVisualizar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(480, 262);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(416, 40);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "BOLETA DE INSCRIPCION";
            // 
            // LblNcarnet
            // 
            this.LblNcarnet.AutoSize = true;
            this.LblNcarnet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNcarnet.ForeColor = System.Drawing.Color.White;
            this.LblNcarnet.Location = new System.Drawing.Point(593, 372);
            this.LblNcarnet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNcarnet.Name = "LblNcarnet";
            this.LblNcarnet.Size = new System.Drawing.Size(258, 30);
            this.LblNcarnet.TabIndex = 1;
            this.LblNcarnet.Text = "NUMERO DE CARNET";
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNumero.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.ForeColor = System.Drawing.Color.White;
            this.TxtNumero.Location = new System.Drawing.Point(868, 366);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(267, 30);
            this.TxtNumero.TabIndex = 2;
            this.TxtNumero.Text = "####";
            this.TxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNumero.TextChanged += new System.EventHandler(this.TxtNumero_TextChanged);
            // 
            // PnlLinea
            // 
            this.PnlLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(55)))), ((int)(((byte)(35)))));
            this.PnlLinea.Location = new System.Drawing.Point(868, 398);
            this.PnlLinea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlLinea.Name = "PnlLinea";
            this.PnlLinea.Size = new System.Drawing.Size(267, 1);
            this.PnlLinea.TabIndex = 3;
            // 
            // PicVisualizar
            // 
            this.PicVisualizar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PicVisualizar.ErrorImage")));
            this.PicVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("PicVisualizar.Image")));
            this.PicVisualizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("PicVisualizar.InitialImage")));
            this.PicVisualizar.Location = new System.Drawing.Point(1179, 430);
            this.PicVisualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PicVisualizar.Name = "PicVisualizar";
            this.PicVisualizar.Size = new System.Drawing.Size(76, 76);
            this.PicVisualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicVisualizar.TabIndex = 5;
            this.PicVisualizar.TabStop = false;
            this.PicVisualizar.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // LblVisualizar
            // 
            this.LblVisualizar.AutoSize = true;
            this.LblVisualizar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVisualizar.ForeColor = System.Drawing.Color.White;
            this.LblVisualizar.Location = new System.Drawing.Point(940, 458);
            this.LblVisualizar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVisualizar.Name = "LblVisualizar";
            this.LblVisualizar.Size = new System.Drawing.Size(223, 25);
            this.LblVisualizar.TabIndex = 6;
            this.LblVisualizar.Text = "VISUALIZAR BOLETA";
            // 
            // FmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.LblVisualizar);
            this.Controls.Add(this.PicVisualizar);
            this.Controls.Add(this.PnlLinea);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblNcarnet);
            this.Controls.Add(this.LblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.PicVisualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNcarnet;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Panel PnlLinea;
        private System.Windows.Forms.PictureBox PicVisualizar;
        private System.Windows.Forms.Label LblVisualizar;
    }
}