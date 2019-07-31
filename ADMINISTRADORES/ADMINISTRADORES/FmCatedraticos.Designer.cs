namespace ADMINISTRADORES
{
    partial class FmCatedraticos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNotas = new System.Windows.Forms.Button();
            this.BtnCursos = new System.Windows.Forms.Button();
            this.PnlEscritorioCatedratico = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.BtnNotas);
            this.panel1.Controls.Add(this.BtnCursos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 52);
            this.panel1.TabIndex = 24;
            // 
            // BtnNotas
            // 
            this.BtnNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.BtnNotas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnNotas.FlatAppearance.BorderSize = 0;
            this.BtnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.BtnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotas.ForeColor = System.Drawing.Color.White;
            this.BtnNotas.Image = global::ADMINISTRADORES.Properties.Resources.review;
            this.BtnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNotas.Location = new System.Drawing.Point(406, 0);
            this.BtnNotas.Name = "BtnNotas";
            this.BtnNotas.Size = new System.Drawing.Size(317, 52);
            this.BtnNotas.TabIndex = 23;
            this.BtnNotas.Text = "Ingreso de Notas";
            this.BtnNotas.UseVisualStyleBackColor = false;
            this.BtnNotas.Click += new System.EventHandler(this.BtnNotas_Click);
            // 
            // BtnCursos
            // 
            this.BtnCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.BtnCursos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.BtnCursos.FlatAppearance.BorderSize = 0;
            this.BtnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.BtnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCursos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCursos.ForeColor = System.Drawing.Color.White;
            this.BtnCursos.Image = global::ADMINISTRADORES.Properties.Resources.notebook_1_;
            this.BtnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCursos.Location = new System.Drawing.Point(220, 0);
            this.BtnCursos.Name = "BtnCursos";
            this.BtnCursos.Size = new System.Drawing.Size(180, 52);
            this.BtnCursos.TabIndex = 20;
            this.BtnCursos.Text = "Cursos";
            this.BtnCursos.UseVisualStyleBackColor = false;
            this.BtnCursos.Click += new System.EventHandler(this.BtnCursos_Click);
            // 
            // PnlEscritorioCatedratico
            // 
            this.PnlEscritorioCatedratico.Location = new System.Drawing.Point(0, 49);
            this.PnlEscritorioCatedratico.Name = "PnlEscritorioCatedratico";
            this.PnlEscritorioCatedratico.Size = new System.Drawing.Size(1300, 571);
            this.PnlEscritorioCatedratico.TabIndex = 25;
            // 
            // FmCatedraticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1300, 623);
            this.Controls.Add(this.PnlEscritorioCatedratico);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FmCatedraticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmCatedraticos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCursos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnNotas;
        private System.Windows.Forms.Panel PnlEscritorioCatedratico;
    }
}