namespace WTiendaOnline.UI
{
    partial class Login
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTelefonoLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEmailLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtContraseñaLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.hlkRegistro = new System.Windows.Forms.LinkLabel();
            this.lblRegistro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTituloLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmailLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.imgLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTelefonoLogin
            // 
            this.lblTelefonoLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonoLogin.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblTelefonoLogin.Location = new System.Drawing.Point(32, 251);
            this.lblTelefonoLogin.Name = "lblTelefonoLogin";
            this.lblTelefonoLogin.Size = new System.Drawing.Size(67, 15);
            this.lblTelefonoLogin.TabIndex = 17;
            this.lblTelefonoLogin.Text = "Telefono";
            // 
            // lblEmailLogin
            // 
            this.lblEmailLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailLogin.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblEmailLogin.Location = new System.Drawing.Point(61, 191);
            this.lblEmailLogin.Name = "lblEmailLogin";
            this.lblEmailLogin.Size = new System.Drawing.Size(43, 15);
            this.lblEmailLogin.TabIndex = 16;
            this.lblEmailLogin.Text = "Email";
            // 
            // txtContraseñaLogin
            // 
            this.txtContraseñaLogin.BorderRadius = 20;
            this.txtContraseñaLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseñaLogin.DefaultText = "";
            this.txtContraseñaLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContraseñaLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContraseñaLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseñaLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseñaLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseñaLogin.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.txtContraseñaLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseñaLogin.Location = new System.Drawing.Point(119, 238);
            this.txtContraseñaLogin.Name = "txtContraseñaLogin";
            this.txtContraseñaLogin.PasswordChar = '\0';
            this.txtContraseñaLogin.PlaceholderText = "";
            this.txtContraseñaLogin.SelectedText = "";
            this.txtContraseñaLogin.Size = new System.Drawing.Size(282, 41);
            this.txtContraseñaLogin.TabIndex = 15;
            // 
            // hlkRegistro
            // 
            this.hlkRegistro.AutoSize = true;
            this.hlkRegistro.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.hlkRegistro.Location = new System.Drawing.Point(276, 392);
            this.hlkRegistro.Name = "hlkRegistro";
            this.hlkRegistro.Size = new System.Drawing.Size(87, 14);
            this.hlkRegistro.TabIndex = 13;
            this.hlkRegistro.TabStop = true;
            this.hlkRegistro.Text = "Registrate";
            this.hlkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hlkRegistro_LinkClicked);
            // 
            // lblRegistro
            // 
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblRegistro.Location = new System.Drawing.Point(91, 392);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(179, 15);
            this.lblRegistro.TabIndex = 11;
            this.lblRegistro.Text = "¿No tienes una cuenta?";
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloLogin.Font = new System.Drawing.Font("Lucida Console", 20F);
            this.lblTituloLogin.Location = new System.Drawing.Point(32, 65);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(355, 29);
            this.lblTituloLogin.TabIndex = 10;
            this.lblTituloLogin.Text = "Bienvenido a Clic&Shop";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(119, 314);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(284, 45);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.BorderRadius = 20;
            this.txtEmailLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailLogin.DefaultText = "";
            this.txtEmailLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailLogin.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.txtEmailLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailLogin.IconLeft = global::WTiendaOnline.Properties.Resources._1077114;
            this.txtEmailLogin.Location = new System.Drawing.Point(119, 179);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.PasswordChar = '\0';
            this.txtEmailLogin.PlaceholderText = "";
            this.txtEmailLogin.SelectedText = "";
            this.txtEmailLogin.Size = new System.Drawing.Size(282, 41);
            this.txtEmailLogin.TabIndex = 14;
            // 
            // imgLogin
            // 
            this.imgLogin.BackColor = System.Drawing.Color.Transparent;
            this.imgLogin.FillColor = System.Drawing.Color.Transparent;
            this.imgLogin.Image = global::WTiendaOnline.Properties.Resources.Imagen_Prueba_2;
            this.imgLogin.ImageRotate = 0F;
            this.imgLogin.Location = new System.Drawing.Point(431, 0);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(469, 483);
            this.imgLogin.TabIndex = 12;
            this.imgLogin.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTelefonoLogin);
            this.Controls.Add(this.lblEmailLogin);
            this.Controls.Add(this.txtContraseñaLogin);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.hlkRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblTituloLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.imgLogin);
            this.Location = new System.Drawing.Point(0, 70);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(900, 480);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTelefonoLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmailLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseñaLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailLogin;
        private System.Windows.Forms.LinkLabel hlkRegistro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRegistro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTituloLogin;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox imgLogin;
    }
}
