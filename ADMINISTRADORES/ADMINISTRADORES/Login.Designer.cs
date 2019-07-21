namespace ADMINISTRADORES
{
    partial class Login
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
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.CboOpciones = new System.Windows.Forms.ComboBox();
            this.LabelSeleccione = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnAceptar.Location = new System.Drawing.Point(661, 319);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(155, 46);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalir.Location = new System.Drawing.Point(824, 319);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(155, 46);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // CboOpciones
            // 
            this.CboOpciones.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboOpciones.FormattingEnabled = true;
            this.CboOpciones.Items.AddRange(new object[] {
            "Administración",
            "Catedrático",
            "Estudiante"});
            this.CboOpciones.Location = new System.Drawing.Point(719, 244);
            this.CboOpciones.Margin = new System.Windows.Forms.Padding(4);
            this.CboOpciones.Name = "CboOpciones";
            this.CboOpciones.Size = new System.Drawing.Size(189, 32);
            this.CboOpciones.TabIndex = 2;
            // 
            // LabelSeleccione
            // 
            this.LabelSeleccione.AutoSize = true;
            this.LabelSeleccione.BackColor = System.Drawing.Color.Transparent;
            this.LabelSeleccione.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeleccione.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelSeleccione.Location = new System.Drawing.Point(589, 171);
            this.LabelSeleccione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSeleccione.Name = "LabelSeleccione";
            this.LabelSeleccione.Size = new System.Drawing.Size(409, 40);
            this.LabelSeleccione.TabIndex = 3;
            this.LabelSeleccione.Text = "Seleccione una opción:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADMINISTRADORES.Properties.Resources._123123121;
            this.ClientSize = new System.Drawing.Size(1067, 521);
            this.Controls.Add(this.LabelSeleccione);
            this.Controls.Add(this.CboOpciones);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAceptar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ComboBox CboOpciones;
        private System.Windows.Forms.Label LabelSeleccione;
    }
}