namespace CapaPresentacion
{
    partial class frmLogin
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.LlbTituloLogin = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconAceptar = new FontAwesome.Sharp.IconButton();
            this.iconCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ScrollBar;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 148;
            this.iconPictureBox1.Location = new System.Drawing.Point(34, 113);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(150, 148);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // LlbTituloLogin
            // 
            this.LlbTituloLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LlbTituloLogin.Location = new System.Drawing.Point(52, 290);
            this.LlbTituloLogin.Name = "LlbTituloLogin";
            this.LlbTituloLogin.Size = new System.Drawing.Size(100, 23);
            this.LlbTituloLogin.TabIndex = 2;
            this.LlbTituloLogin.Text = "Sistema POS";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(296, 135);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(106, 16);
            this.lblIdUsuario.TabIndex = 3;
            this.lblIdUsuario.Text = "Nombre Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // txtUuario
            // 
            this.txtUuario.Location = new System.Drawing.Point(299, 155);
            this.txtUuario.Name = "txtUuario";
            this.txtUuario.Size = new System.Drawing.Size(100, 22);
            this.txtUuario.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(299, 222);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 22);
            this.txtContraseña.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // iconAceptar
            // 
            this.iconAceptar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconAceptar.IconColor = System.Drawing.Color.Black;
            this.iconAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAceptar.Location = new System.Drawing.Point(299, 290);
            this.iconAceptar.Name = "iconAceptar";
            this.iconAceptar.Size = new System.Drawing.Size(75, 23);
            this.iconAceptar.TabIndex = 8;
            this.iconAceptar.Text = "Aceptar";
            this.iconAceptar.UseVisualStyleBackColor = true;
            this.iconAceptar.Click += new System.EventHandler(this.iconAceptar_Click);
            // 
            // iconCancelar
            // 
            this.iconCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconCancelar.IconColor = System.Drawing.Color.Black;
            this.iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCancelar.Location = new System.Drawing.Point(489, 290);
            this.iconCancelar.Name = "iconCancelar";
            this.iconCancelar.Size = new System.Drawing.Size(75, 23);
            this.iconCancelar.TabIndex = 9;
            this.iconCancelar.Text = "Cancelar";
            this.iconCancelar.UseVisualStyleBackColor = true;
            this.iconCancelar.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.iconAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.iconCancelar;
            this.ClientSize = new System.Drawing.Size(695, 422);
            this.Controls.Add(this.iconCancelar);
            this.Controls.Add(this.iconAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.LlbTituloLogin);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label LlbTituloLogin;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconAceptar;
        private FontAwesome.Sharp.IconButton iconCancelar;
    }
}