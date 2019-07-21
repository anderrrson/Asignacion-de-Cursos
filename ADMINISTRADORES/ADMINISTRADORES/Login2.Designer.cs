namespace ADMINISTRADORES
{
    partial class Login2
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
            this.LabelBienvenido = new System.Windows.Forms.Label();
            this.LabelIngreso = new System.Windows.Forms.Label();
            this.PnlUser = new System.Windows.Forms.Panel();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.PicUser = new System.Windows.Forms.PictureBox();
            this.PnlPassword = new System.Windows.Forms.Panel();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.PicPassword = new System.Windows.Forms.PictureBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.LnblOlvidoPassword = new System.Windows.Forms.LinkLabel();
            this.PnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).BeginInit();
            this.PnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelBienvenido
            // 
            this.LabelBienvenido.AutoSize = true;
            this.LabelBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.LabelBienvenido.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBienvenido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelBienvenido.Location = new System.Drawing.Point(89, 298);
            this.LabelBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBienvenido.Name = "LabelBienvenido";
            this.LabelBienvenido.Size = new System.Drawing.Size(342, 50);
            this.LabelBienvenido.TabIndex = 0;
            this.LabelBienvenido.Text = "Bienvenido al portal de \r\nla Universidad Mariano Gálvez";
            this.LabelBienvenido.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LabelIngreso
            // 
            this.LabelIngreso.AutoSize = true;
            this.LabelIngreso.BackColor = System.Drawing.Color.Transparent;
            this.LabelIngreso.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIngreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelIngreso.Location = new System.Drawing.Point(585, 154);
            this.LabelIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelIngreso.Name = "LabelIngreso";
            this.LabelIngreso.Size = new System.Drawing.Size(222, 25);
            this.LabelIngreso.TabIndex = 1;
            this.LabelIngreso.Text = "Ingrese a su cuenta";
            // 
            // PnlUser
            // 
            this.PnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.PnlUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlUser.Controls.Add(this.TxtUser);
            this.PnlUser.Controls.Add(this.PicUser);
            this.PnlUser.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlUser.Location = new System.Drawing.Point(543, 202);
            this.PnlUser.Margin = new System.Windows.Forms.Padding(4);
            this.PnlUser.Name = "PnlUser";
            this.PnlUser.Size = new System.Drawing.Size(522, 43);
            this.PnlUser.TabIndex = 2;
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtUser.Location = new System.Drawing.Point(63, 9);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(413, 27);
            this.TxtUser.TabIndex = 5;
            this.TxtUser.Text = "User name";
            // 
            // PicUser
            // 
            this.PicUser.BackColor = System.Drawing.Color.Transparent;
            this.PicUser.BackgroundImage = global::ADMINISTRADORES.Properties.Resources.user_1_;
            this.PicUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicUser.Location = new System.Drawing.Point(19, 2);
            this.PicUser.Margin = new System.Windows.Forms.Padding(4);
            this.PicUser.Name = "PicUser";
            this.PicUser.Size = new System.Drawing.Size(36, 36);
            this.PicUser.TabIndex = 4;
            this.PicUser.TabStop = false;
            // 
            // PnlPassword
            // 
            this.PnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.PnlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPassword.Controls.Add(this.TxtPassword);
            this.PnlPassword.Controls.Add(this.PicPassword);
            this.PnlPassword.ForeColor = System.Drawing.Color.DimGray;
            this.PnlPassword.Location = new System.Drawing.Point(543, 245);
            this.PnlPassword.Margin = new System.Windows.Forms.Padding(4);
            this.PnlPassword.Name = "PnlPassword";
            this.PnlPassword.Size = new System.Drawing.Size(522, 43);
            this.PnlPassword.TabIndex = 3;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtPassword.Location = new System.Drawing.Point(63, 7);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(413, 27);
            this.TxtPassword.TabIndex = 6;
            this.TxtPassword.Text = "Password";
            // 
            // PicPassword
            // 
            this.PicPassword.BackColor = System.Drawing.Color.Transparent;
            this.PicPassword.BackgroundImage = global::ADMINISTRADORES.Properties.Resources._lock;
            this.PicPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicPassword.Location = new System.Drawing.Point(19, 2);
            this.PicPassword.Margin = new System.Windows.Forms.Padding(4);
            this.PicPassword.Name = "PicPassword";
            this.PicPassword.Size = new System.Drawing.Size(36, 36);
            this.PicPassword.TabIndex = 5;
            this.PicPassword.TabStop = false;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegresar.Location = new System.Drawing.Point(800, 357);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(155, 46);
            this.BtnRegresar.TabIndex = 5;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(607, 357);
            this.BtnIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(185, 46);
            this.BtnIniciarSesion.TabIndex = 4;
            this.BtnIniciarSesion.Text = "Iniciar sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // LnblOlvidoPassword
            // 
            this.LnblOlvidoPassword.ActiveLinkColor = System.Drawing.Color.White;
            this.LnblOlvidoPassword.AutoSize = true;
            this.LnblOlvidoPassword.BackColor = System.Drawing.Color.Transparent;
            this.LnblOlvidoPassword.LinkColor = System.Drawing.Color.White;
            this.LnblOlvidoPassword.Location = new System.Drawing.Point(876, 298);
            this.LnblOlvidoPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LnblOlvidoPassword.Name = "LnblOlvidoPassword";
            this.LnblOlvidoPassword.Size = new System.Drawing.Size(174, 17);
            this.LnblOlvidoPassword.TabIndex = 6;
            this.LnblOlvidoPassword.TabStop = true;
            this.LnblOlvidoPassword.Text = "¿Olvidaste tu contraseña?";
            this.LnblOlvidoPassword.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // Login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADMINISTRADORES.Properties.Resources._99871;
            this.ClientSize = new System.Drawing.Size(1067, 521);
            this.Controls.Add(this.LnblOlvidoPassword);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.PnlPassword);
            this.Controls.Add(this.PnlUser);
            this.Controls.Add(this.LabelIngreso);
            this.Controls.Add(this.LabelBienvenido);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login2";
            this.Text = "Form2";
            this.PnlUser.ResumeLayout(false);
            this.PnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).EndInit();
            this.PnlPassword.ResumeLayout(false);
            this.PnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelBienvenido;
        private System.Windows.Forms.Label LabelIngreso;
        private System.Windows.Forms.Panel PnlUser;
        private System.Windows.Forms.Panel PnlPassword;
        private System.Windows.Forms.PictureBox PicUser;
        private System.Windows.Forms.PictureBox PicPassword;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.LinkLabel LnblOlvidoPassword;
    }
}