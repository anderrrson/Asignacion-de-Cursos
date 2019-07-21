namespace ADMINISTRADORES
{
    partial class Estudiante
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PnlSeparador = new System.Windows.Forms.Panel();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnNotas = new System.Windows.Forms.Button();
            this.BtnHorario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(29, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(132, 25);
            this.LblTitulo.TabIndex = 17;
            this.LblTitulo.Text = "Estudiantes";
            this.LblTitulo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PnlSeparador
            // 
            this.PnlSeparador.BackColor = System.Drawing.Color.Red;
            this.PnlSeparador.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparador.Location = new System.Drawing.Point(17, 37);
            this.PnlSeparador.Name = "PnlSeparador";
            this.PnlSeparador.Size = new System.Drawing.Size(752, 1);
            this.PnlSeparador.TabIndex = 16;
            this.PnlSeparador.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnRegresar.FlatAppearance.BorderSize = 2;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Image = global::ADMINISTRADORES.Properties.Resources.regresar;
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRegresar.Location = new System.Drawing.Point(17, 44);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(75, 57);
            this.BtnRegresar.TabIndex = 22;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnNotas
            // 
            this.BtnNotas.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnNotas.FlatAppearance.BorderSize = 2;
            this.BtnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotas.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotas.ForeColor = System.Drawing.Color.White;
            this.BtnNotas.Image = global::ADMINISTRADORES.Properties.Resources.notas;
            this.BtnNotas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNotas.Location = new System.Drawing.Point(434, 136);
            this.BtnNotas.Name = "BtnNotas";
            this.BtnNotas.Size = new System.Drawing.Size(169, 179);
            this.BtnNotas.TabIndex = 21;
            this.BtnNotas.Text = "Notas";
            this.BtnNotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNotas.UseVisualStyleBackColor = true;
            this.BtnNotas.Click += new System.EventHandler(this.BtnNotas_Click);
            // 
            // BtnHorario
            // 
            this.BtnHorario.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnHorario.FlatAppearance.BorderSize = 2;
            this.BtnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHorario.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHorario.ForeColor = System.Drawing.Color.White;
            this.BtnHorario.Image = global::ADMINISTRADORES.Properties.Resources.horario_2_;
            this.BtnHorario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnHorario.Location = new System.Drawing.Point(233, 136);
            this.BtnHorario.Name = "BtnHorario";
            this.BtnHorario.Size = new System.Drawing.Size(169, 179);
            this.BtnHorario.TabIndex = 20;
            this.BtnHorario.Text = "Horario";
            this.BtnHorario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHorario.UseVisualStyleBackColor = true;
            this.BtnHorario.Click += new System.EventHandler(this.BtnHorario_Click);
            // 
            // Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnNotas);
            this.Controls.Add(this.BtnHorario);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PnlSeparador);
            this.Name = "Estudiante";
            this.Text = "Estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PnlSeparador;
        private System.Windows.Forms.Button BtnNotas;
        private System.Windows.Forms.Button BtnHorario;
        private System.Windows.Forms.Button BtnRegresar;
    }
}