namespace ADMINISTRADORES
{
    partial class FmCursosCatedratico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmCursosCatedratico));
            this.LblTituloCatedratico = new System.Windows.Forms.Label();
            this.LblTituloAño = new System.Windows.Forms.Label();
            this.TxtCodigoCatedratico = new System.Windows.Forms.TextBox();
            this.TxtAño = new System.Windows.Forms.TextBox();
            this.PnlSeparadorCodigoCatedratico = new System.Windows.Forms.Panel();
            this.PnlSeparadorAño = new System.Windows.Forms.Panel();
            this.LblTituloCursos = new System.Windows.Forms.Label();
            this.PnlSeparadorCursos = new System.Windows.Forms.Panel();
            this.DgvCursos = new System.Windows.Forms.DataGridView();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTituloCatedratico
            // 
            this.LblTituloCatedratico.AutoSize = true;
            this.LblTituloCatedratico.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCatedratico.ForeColor = System.Drawing.Color.White;
            this.LblTituloCatedratico.Location = new System.Drawing.Point(84, 41);
            this.LblTituloCatedratico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTituloCatedratico.Name = "LblTituloCatedratico";
            this.LblTituloCatedratico.Size = new System.Drawing.Size(196, 22);
            this.LblTituloCatedratico.TabIndex = 11;
            this.LblTituloCatedratico.Text = "Codigo Catedrático";
            this.LblTituloCatedratico.Click += new System.EventHandler(this.LblTituloCarnet_Click);
            // 
            // LblTituloAño
            // 
            this.LblTituloAño.AutoSize = true;
            this.LblTituloAño.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloAño.ForeColor = System.Drawing.Color.White;
            this.LblTituloAño.Location = new System.Drawing.Point(515, 41);
            this.LblTituloAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTituloAño.Name = "LblTituloAño";
            this.LblTituloAño.Size = new System.Drawing.Size(49, 22);
            this.LblTituloAño.TabIndex = 10;
            this.LblTituloAño.Text = "Año";
            // 
            // TxtCodigoCatedratico
            // 
            this.TxtCodigoCatedratico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TxtCodigoCatedratico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCodigoCatedratico.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoCatedratico.ForeColor = System.Drawing.Color.White;
            this.TxtCodigoCatedratico.Location = new System.Drawing.Point(89, 69);
            this.TxtCodigoCatedratico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCodigoCatedratico.Name = "TxtCodigoCatedratico";
            this.TxtCodigoCatedratico.Size = new System.Drawing.Size(240, 33);
            this.TxtCodigoCatedratico.TabIndex = 8;
            // 
            // TxtAño
            // 
            this.TxtAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.TxtAño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAño.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAño.ForeColor = System.Drawing.Color.White;
            this.TxtAño.Location = new System.Drawing.Point(520, 69);
            this.TxtAño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtAño.Name = "TxtAño";
            this.TxtAño.Size = new System.Drawing.Size(240, 33);
            this.TxtAño.TabIndex = 12;
            // 
            // PnlSeparadorCodigoCatedratico
            // 
            this.PnlSeparadorCodigoCatedratico.BackColor = System.Drawing.Color.Red;
            this.PnlSeparadorCodigoCatedratico.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparadorCodigoCatedratico.Location = new System.Drawing.Point(89, 108);
            this.PnlSeparadorCodigoCatedratico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlSeparadorCodigoCatedratico.Name = "PnlSeparadorCodigoCatedratico";
            this.PnlSeparadorCodigoCatedratico.Size = new System.Drawing.Size(267, 1);
            this.PnlSeparadorCodigoCatedratico.TabIndex = 13;
            // 
            // PnlSeparadorAño
            // 
            this.PnlSeparadorAño.BackColor = System.Drawing.Color.Red;
            this.PnlSeparadorAño.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparadorAño.Location = new System.Drawing.Point(520, 108);
            this.PnlSeparadorAño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlSeparadorAño.Name = "PnlSeparadorAño";
            this.PnlSeparadorAño.Size = new System.Drawing.Size(267, 1);
            this.PnlSeparadorAño.TabIndex = 14;
            // 
            // LblTituloCursos
            // 
            this.LblTituloCursos.AutoSize = true;
            this.LblTituloCursos.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCursos.ForeColor = System.Drawing.Color.White;
            this.LblTituloCursos.Location = new System.Drawing.Point(53, 178);
            this.LblTituloCursos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTituloCursos.Name = "LblTituloCursos";
            this.LblTituloCursos.Size = new System.Drawing.Size(99, 33);
            this.LblTituloCursos.TabIndex = 16;
            this.LblTituloCursos.Text = "Cursos";
            // 
            // PnlSeparadorCursos
            // 
            this.PnlSeparadorCursos.BackColor = System.Drawing.Color.Red;
            this.PnlSeparadorCursos.ForeColor = System.Drawing.Color.Red;
            this.PnlSeparadorCursos.Location = new System.Drawing.Point(37, 213);
            this.PnlSeparadorCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlSeparadorCursos.Name = "PnlSeparadorCursos";
            this.PnlSeparadorCursos.Size = new System.Drawing.Size(1680, 1);
            this.PnlSeparadorCursos.TabIndex = 15;
            // 
            // DgvCursos
            // 
            this.DgvCursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.DgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCursos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvCursos.GridColor = System.Drawing.Color.Black;
            this.DgvCursos.Location = new System.Drawing.Point(60, 222);
            this.DgvCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvCursos.Name = "DgvCursos";
            this.DgvCursos.Size = new System.Drawing.Size(1627, 306);
            this.DgvCursos.TabIndex = 17;
            this.DgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCursos_CellContentClick);
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
            this.BtnExportar.Location = new System.Drawing.Point(1284, 50);
            this.BtnExportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BtnExportar.Size = new System.Drawing.Size(197, 50);
            this.BtnExportar.TabIndex = 19;
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
            this.BtnBuscar.Location = new System.Drawing.Point(1039, 50);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnBuscar.Size = new System.Drawing.Size(197, 50);
            this.BtnBuscar.TabIndex = 18;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FmCursosCatedratico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1733, 703);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DgvCursos);
            this.Controls.Add(this.LblTituloCursos);
            this.Controls.Add(this.PnlSeparadorCursos);
            this.Controls.Add(this.PnlSeparadorAño);
            this.Controls.Add(this.PnlSeparadorCodigoCatedratico);
            this.Controls.Add(this.TxtAño);
            this.Controls.Add(this.LblTituloCatedratico);
            this.Controls.Add(this.LblTituloAño);
            this.Controls.Add(this.TxtCodigoCatedratico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FmCursosCatedratico";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloCatedratico;
        private System.Windows.Forms.Label LblTituloAño;
        private System.Windows.Forms.TextBox TxtCodigoCatedratico;
        private System.Windows.Forms.TextBox TxtAño;
        private System.Windows.Forms.Panel PnlSeparadorCodigoCatedratico;
        private System.Windows.Forms.Panel PnlSeparadorAño;
        private System.Windows.Forms.Label LblTituloCursos;
        private System.Windows.Forms.Panel PnlSeparadorCursos;
        private System.Windows.Forms.DataGridView DgvCursos;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Button BtnBuscar;
    }
}