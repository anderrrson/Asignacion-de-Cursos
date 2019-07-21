namespace ADMINISTRADORES
{
    partial class Inscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripcion));
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
            this.LblTitulo.Location = new System.Drawing.Point(360, 213);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(328, 33);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "BOLETA DE INSCRIPCION";
            // 
            // LblNcarnet
            // 
            this.LblNcarnet.AutoSize = true;
            this.LblNcarnet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNcarnet.ForeColor = System.Drawing.Color.White;
            this.LblNcarnet.Location = new System.Drawing.Point(445, 302);
            this.LblNcarnet.Name = "LblNcarnet";
            this.LblNcarnet.Size = new System.Drawing.Size(200, 22);
            this.LblNcarnet.TabIndex = 1;
            this.LblNcarnet.Text = "NUMERO DE CARNET";
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNumero.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.ForeColor = System.Drawing.Color.White;
            this.TxtNumero.Location = new System.Drawing.Point(651, 297);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(200, 24);
            this.TxtNumero.TabIndex = 2;
            this.TxtNumero.Text = "####";
            this.TxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNumero.TextChanged += new System.EventHandler(this.TxtNumero_TextChanged);
            // 
            // PnlLinea
            // 
            this.PnlLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(55)))), ((int)(((byte)(35)))));
            this.PnlLinea.Location = new System.Drawing.Point(651, 323);
            this.PnlLinea.Name = "PnlLinea";
            this.PnlLinea.Size = new System.Drawing.Size(200, 1);
            this.PnlLinea.TabIndex = 3;
            // 
            // PicVisualizar
            // 
            this.PicVisualizar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PicVisualizar.ErrorImage")));
            this.PicVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("PicVisualizar.Image")));
            this.PicVisualizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("PicVisualizar.InitialImage")));
            this.PicVisualizar.Location = new System.Drawing.Point(884, 349);
            this.PicVisualizar.Name = "PicVisualizar";
            this.PicVisualizar.Size = new System.Drawing.Size(57, 62);
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
            this.LblVisualizar.Location = new System.Drawing.Point(705, 372);
            this.LblVisualizar.Name = "LblVisualizar";
            this.LblVisualizar.Size = new System.Drawing.Size(173, 21);
            this.LblVisualizar.TabIndex = 6;
            this.LblVisualizar.Text = "VISUALIZAR BOLETA";
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.LblVisualizar);
            this.Controls.Add(this.PicVisualizar);
            this.Controls.Add(this.PnlLinea);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblNcarnet);
            this.Controls.Add(this.LblTitulo);
            this.Name = "Inscripcion";
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