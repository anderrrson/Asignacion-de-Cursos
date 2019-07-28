namespace ADMINISTRADORES
{
    partial class FmLogin
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
            this.LnblOlvidoPassword = new System.Windows.Forms.LinkLabel();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.PicPassword = new System.Windows.Forms.PictureBox();
            this.LabelIniciarSesion = new System.Windows.Forms.Label();
            this.PicUser = new System.Windows.Forms.PictureBox();
            this.PnlUser = new System.Windows.Forms.Panel();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.PnlPassword = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PnlTipoUsuario = new System.Windows.Forms.Panel();
            this.PicTiposUsuarios = new System.Windows.Forms.PictureBox();
            this.CboTiposUsuarios = new System.Windows.Forms.ComboBox();
            this.BtnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).BeginInit();
            this.PnlUser.SuspendLayout();
            this.PnlPassword.SuspendLayout();
            this.PnlTipoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTiposUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // LnblOlvidoPassword
            // 
            this.LnblOlvidoPassword.ActiveLinkColor = System.Drawing.Color.White;
            this.LnblOlvidoPassword.AutoSize = true;
            this.LnblOlvidoPassword.BackColor = System.Drawing.Color.Transparent;
            this.LnblOlvidoPassword.LinkColor = System.Drawing.Color.White;
            this.LnblOlvidoPassword.Location = new System.Drawing.Point(551, 352);
            this.LnblOlvidoPassword.Name = "LnblOlvidoPassword";
            this.LnblOlvidoPassword.Size = new System.Drawing.Size(131, 13);
            this.LnblOlvidoPassword.TabIndex = 12;
            this.LnblOlvidoPassword.TabStop = true;
            this.LnblOlvidoPassword.Text = "¿Olvidaste tu contraseña?";
            this.LnblOlvidoPassword.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(546, 299);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(139, 37);
            this.BtnIniciarSesion.TabIndex = 10;
            this.BtnIniciarSesion.Text = "Iniciar sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseña.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtContraseña.Location = new System.Drawing.Point(457, 194);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(310, 21);
            this.TxtContraseña.TabIndex = 6;
            this.TxtContraseña.Text = "Contraseña";
            this.TxtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            this.TxtContraseña.Leave += new System.EventHandler(this.TxtContraseña_Leave);
            // 
            // PicPassword
            // 
            this.PicPassword.BackColor = System.Drawing.Color.Transparent;
            this.PicPassword.BackgroundImage = global::ADMINISTRADORES.Properties.Resources._lock;
            this.PicPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicPassword.Location = new System.Drawing.Point(416, 191);
            this.PicPassword.Name = "PicPassword";
            this.PicPassword.Size = new System.Drawing.Size(27, 29);
            this.PicPassword.TabIndex = 5;
            this.PicPassword.TabStop = false;
            // 
            // LabelIniciarSesion
            // 
            this.LabelIniciarSesion.AutoSize = true;
            this.LabelIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.LabelIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelIniciarSesion.Location = new System.Drawing.Point(418, 105);
            this.LabelIniciarSesion.Name = "LabelIniciarSesion";
            this.LabelIniciarSesion.Size = new System.Drawing.Size(114, 21);
            this.LabelIniciarSesion.TabIndex = 7;
            this.LabelIniciarSesion.Text = "Iniciar Sesión";
            this.LabelIniciarSesion.Click += new System.EventHandler(this.LabelIngreso_Click);
            // 
            // PicUser
            // 
            this.PicUser.BackColor = System.Drawing.Color.Transparent;
            this.PicUser.BackgroundImage = global::ADMINISTRADORES.Properties.Resources.user_1_;
            this.PicUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicUser.Location = new System.Drawing.Point(8, 2);
            this.PicUser.Name = "PicUser";
            this.PicUser.Size = new System.Drawing.Size(27, 29);
            this.PicUser.TabIndex = 4;
            this.PicUser.TabStop = false;
            // 
            // PnlUser
            // 
            this.PnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.PnlUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlUser.Controls.Add(this.TxtUsuario);
            this.PnlUser.Controls.Add(this.PicUser);
            this.PnlUser.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlUser.Location = new System.Drawing.Point(407, 153);
            this.PnlUser.Name = "PnlUser";
            this.PnlUser.Size = new System.Drawing.Size(392, 35);
            this.PnlUser.TabIndex = 8;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtUsuario.Location = new System.Drawing.Point(49, 6);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(310, 21);
            this.TxtUsuario.TabIndex = 7;
            this.TxtUsuario.Text = "Usuario";
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUserName_Enter);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUserName_Leave);
            // 
            // PnlPassword
            // 
            this.PnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.PnlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPassword.Controls.Add(this.panel1);
            this.PnlPassword.ForeColor = System.Drawing.Color.DimGray;
            this.PnlPassword.Location = new System.Drawing.Point(407, 188);
            this.PnlPassword.Name = "PnlPassword";
            this.PnlPassword.Size = new System.Drawing.Size(392, 35);
            this.PnlPassword.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(2, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 35);
            this.panel1.TabIndex = 14;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.BtnClose.BackgroundImage = global::ADMINISTRADORES.Properties.Resources.icon_1_1;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.BtnClose.Location = new System.Drawing.Point(752, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(37, 31);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // PnlTipoUsuario
            // 
            this.PnlTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.PnlTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTipoUsuario.Controls.Add(this.PicTiposUsuarios);
            this.PnlTipoUsuario.Controls.Add(this.CboTiposUsuarios);
            this.PnlTipoUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.PnlTipoUsuario.Location = new System.Drawing.Point(407, 223);
            this.PnlTipoUsuario.Name = "PnlTipoUsuario";
            this.PnlTipoUsuario.Size = new System.Drawing.Size(392, 45);
            this.PnlTipoUsuario.TabIndex = 14;
            // 
            // PicTiposUsuarios
            // 
            this.PicTiposUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.PicTiposUsuarios.BackgroundImage = global::ADMINISTRADORES.Properties.Resources.group;
            this.PicTiposUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicTiposUsuarios.Location = new System.Drawing.Point(8, 5);
            this.PicTiposUsuarios.Name = "PicTiposUsuarios";
            this.PicTiposUsuarios.Size = new System.Drawing.Size(30, 32);
            this.PicTiposUsuarios.TabIndex = 15;
            this.PicTiposUsuarios.TabStop = false;
            // 
            // CboTiposUsuarios
            // 
            this.CboTiposUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.CboTiposUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboTiposUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTiposUsuarios.ForeColor = System.Drawing.Color.DarkGray;
            this.CboTiposUsuarios.FormattingEnabled = true;
            this.CboTiposUsuarios.Items.AddRange(new object[] {
            "Administrador",
            "Catedrático",
            "Estudiante"});
            this.CboTiposUsuarios.Location = new System.Drawing.Point(49, 8);
            this.CboTiposUsuarios.Name = "CboTiposUsuarios";
            this.CboTiposUsuarios.Size = new System.Drawing.Size(231, 29);
            this.CboTiposUsuarios.TabIndex = 15;
            this.CboTiposUsuarios.Text = "Seleccione una opción...";
            this.CboTiposUsuarios.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.BtnAyuda.BackgroundImage = global::ADMINISTRADORES.Properties.Resources.question_mark;
            this.BtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.BtnAyuda.Location = new System.Drawing.Point(709, 11);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(37, 31);
            this.BtnAyuda.TabIndex = 15;
            this.BtnAyuda.UseVisualStyleBackColor = false;
            // 
            // FmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADMINISTRADORES.Properties.Resources._123123121;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.PnlTipoUsuario);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.PicPassword);
            this.Controls.Add(this.LnblOlvidoPassword);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.PnlUser);
            this.Controls.Add(this.PnlPassword);
            this.Controls.Add(this.LabelIniciarSesion);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).EndInit();
            this.PnlUser.ResumeLayout(false);
            this.PnlUser.PerformLayout();
            this.PnlPassword.ResumeLayout(false);
            this.PnlTipoUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicTiposUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel LnblOlvidoPassword;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.PictureBox PicPassword;
        private System.Windows.Forms.Label LabelIniciarSesion;
        private System.Windows.Forms.PictureBox PicUser;
        private System.Windows.Forms.Panel PnlUser;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Panel PnlPassword;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlTipoUsuario;
        private System.Windows.Forms.ComboBox CboTiposUsuarios;
        private System.Windows.Forms.PictureBox PicTiposUsuarios;
        private System.Windows.Forms.Button BtnAyuda;
    }
}