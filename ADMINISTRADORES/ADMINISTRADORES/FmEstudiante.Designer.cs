
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHorario = new System.Windows.Forms.Button();
            this.BtnNotas = new System.Windows.Forms.Button();
            this.PnlEscritorioEstudiante = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.BtnHorario);
            this.panel1.Controls.Add(this.BtnNotas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 52);
            this.panel1.TabIndex = 23;
            // 
            // BtnHorario
            // 
            this.BtnHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.BtnHorario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.BtnHorario.FlatAppearance.BorderSize = 0;
            this.BtnHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(23)))));
            this.BtnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHorario.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHorario.ForeColor = System.Drawing.Color.White;
            this.BtnHorario.Image = global::ADMINISTRADORES.Properties.Resources.calendar;
            this.BtnHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHorario.Location = new System.Drawing.Point(220, 0);
            this.BtnHorario.Name = "BtnHorario";
            this.BtnHorario.Size = new System.Drawing.Size(180, 52);
            this.BtnHorario.TabIndex = 20;
            this.BtnHorario.Text = "Horario";
            this.BtnHorario.UseVisualStyleBackColor = false;
            this.BtnHorario.Click += new System.EventHandler(this.BtnHorario_Click);
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
            this.BtnNotas.Image = global::ADMINISTRADORES.Properties.Resources.notepad;
            this.BtnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNotas.Location = new System.Drawing.Point(406, 0);
            this.BtnNotas.Name = "BtnNotas";
            this.BtnNotas.Size = new System.Drawing.Size(180, 52);
            this.BtnNotas.TabIndex = 21;
            this.BtnNotas.Text = "Notas";
            this.BtnNotas.UseVisualStyleBackColor = false;
            this.BtnNotas.Click += new System.EventHandler(this.BtnNotas_Click);
            // 
            // PnlEscritorioEstudiante
            // 
            this.PnlEscritorioEstudiante.Location = new System.Drawing.Point(0, 51);
            this.PnlEscritorioEstudiante.Name = "PnlEscritorioEstudiante";
            this.PnlEscritorioEstudiante.Size = new System.Drawing.Size(1300, 571);
            this.PnlEscritorioEstudiante.TabIndex = 24;
            // 
            // FmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1300, 623);
            this.Controls.Add(this.PnlEscritorioEstudiante);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnNotas;
        private System.Windows.Forms.Button BtnHorario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlEscritorioEstudiante;
    }
}