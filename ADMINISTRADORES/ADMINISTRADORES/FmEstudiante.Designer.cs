namespace ADMINISTRADORES
{
    partial class FmEstudiante
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnNotas = new System.Windows.Forms.Button();
            this.BtnHorario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(45, 61);
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
            this.PnlSeparador.Location = new System.Drawing.Point(33, 89);
            this.PnlSeparador.Name = "PnlSeparador";
            this.PnlSeparador.Size = new System.Drawing.Size(1250, 1);
            this.PnlSeparador.TabIndex = 16;
            this.PnlSeparador.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 39);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administracion";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 661);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1300, 39);
            this.panel4.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1031, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "26/07/2019";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1156, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "1:00:00 PM";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Usuario";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ADMINISTRADORES.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(12, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ADMINISTRADORES.Properties.Resources.minForm;
            this.pictureBox2.Location = new System.Drawing.Point(1202, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ADMINISTRADORES.Properties.Resources.cerrarForm;
            this.pictureBox1.Location = new System.Drawing.Point(1248, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.BtnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnRegresar.FlatAppearance.BorderSize = 2;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Image = global::ADMINISTRADORES.Properties.Resources.regresar;
            this.BtnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRegresar.Location = new System.Drawing.Point(50, 108);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(75, 57);
            this.BtnRegresar.TabIndex = 22;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnNotas
            // 
            this.BtnNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.BtnNotas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnNotas.FlatAppearance.BorderSize = 2;
            this.BtnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotas.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotas.ForeColor = System.Drawing.Color.White;
            this.BtnNotas.Image = global::ADMINISTRADORES.Properties.Resources.notepad1;
            this.BtnNotas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNotas.Location = new System.Drawing.Point(545, 245);
            this.BtnNotas.Name = "BtnNotas";
            this.BtnNotas.Size = new System.Drawing.Size(159, 104);
            this.BtnNotas.TabIndex = 21;
            this.BtnNotas.Text = "Notas";
            this.BtnNotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNotas.UseVisualStyleBackColor = false;
            this.BtnNotas.Click += new System.EventHandler(this.BtnNotas_Click);
            // 
            // BtnHorario
            // 
            this.BtnHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.BtnHorario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnHorario.FlatAppearance.BorderSize = 2;
            this.BtnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHorario.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHorario.ForeColor = System.Drawing.Color.White;
            this.BtnHorario.Image = global::ADMINISTRADORES.Properties.Resources.calendar1;
            this.BtnHorario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnHorario.Location = new System.Drawing.Point(348, 245);
            this.BtnHorario.Name = "BtnHorario";
            this.BtnHorario.Size = new System.Drawing.Size(159, 104);
            this.BtnHorario.TabIndex = 20;
            this.BtnHorario.Text = "Horario";
            this.BtnHorario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHorario.UseVisualStyleBackColor = false;
            this.BtnHorario.Click += new System.EventHandler(this.BtnHorario_Click);
            // 
            // FmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnNotas);
            this.Controls.Add(this.BtnHorario);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PnlSeparador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PnlSeparador;
        private System.Windows.Forms.Button BtnNotas;
        private System.Windows.Forms.Button BtnHorario;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}