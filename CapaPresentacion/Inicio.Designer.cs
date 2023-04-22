namespace CapaPresentacion
{
    partial class FrmInicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IconUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            this.IconCompras = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.IconVentas = new FontAwesome.Sharp.IconMenuItem();
            this.IconProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.sistemaDeComprasYVentasPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.MenuTitulo.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconUsuario,
            this.iconMenuItem5,
            this.iconMenuItem2,
            this.IconCompras,
            this.IconProveedores,
            this.IconVentas,
            this.iconMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 49);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(160, 440);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IconUsuario
            // 
            this.IconUsuario.AutoSize = false;
            this.IconUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.IconUsuario.IconColor = System.Drawing.Color.Black;
            this.IconUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IconUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconUsuario.Name = "IconUsuario";
            this.IconUsuario.Size = new System.Drawing.Size(152, 60);
            this.IconUsuario.Text = "Usuarios";
            this.IconUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem5
            // 
            this.iconMenuItem5.AutoSize = false;
            this.iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.iconMenuItem5.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem5.Name = "iconMenuItem5";
            this.iconMenuItem5.Size = new System.Drawing.Size(152, 60);
            this.iconMenuItem5.Text = "Catalogos";
            this.iconMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItem5.Click += new System.EventHandler(this.iconMenuItem5_Click);
            // 
            // IconCompras
            // 
            this.IconCompras.AutoSize = false;
            this.IconCompras.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.IconCompras.IconColor = System.Drawing.Color.Black;
            this.IconCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IconCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconCompras.Name = "IconCompras";
            this.IconCompras.Size = new System.Drawing.Size(152, 60);
            this.IconCompras.Text = "Compras";
            this.IconCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconCompras.Click += new System.EventHandler(this.iconMenuItem4_Click);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.AutoSize = false;
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(152, 60);
            this.iconMenuItem2.Text = "Ventas";
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IconVentas
            // 
            this.IconVentas.AutoSize = false;
            this.IconVentas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.IconVentas.IconColor = System.Drawing.Color.Black;
            this.IconVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IconVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconVentas.Name = "IconVentas";
            this.IconVentas.Size = new System.Drawing.Size(152, 60);
            this.IconVentas.Text = "Ventas";
            this.IconVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // IconProveedores
            // 
            this.IconProveedores.AutoSize = false;
            this.IconProveedores.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.IconProveedores.IconColor = System.Drawing.Color.Black;
            this.IconProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IconProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconProveedores.Name = "IconProveedores";
            this.IconProveedores.Size = new System.Drawing.Size(152, 60);
            this.IconProveedores.Text = "Proveedores";
            this.IconProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.AutoSize = false;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(152, 60);
            this.iconMenuItem1.Text = "Reportes";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaDeComprasYVentasPOSToolStripMenuItem});
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.Size = new System.Drawing.Size(909, 49);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.Text = "menuStrip2";
            // 
            // sistemaDeComprasYVentasPOSToolStripMenuItem
            // 
            this.sistemaDeComprasYVentasPOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistemaDeComprasYVentasPOSToolStripMenuItem.Name = "sistemaDeComprasYVentasPOSToolStripMenuItem";
            this.sistemaDeComprasYVentasPOSToolStripMenuItem.Size = new System.Drawing.Size(487, 45);
            this.sistemaDeComprasYVentasPOSToolStripMenuItem.Text = "Sistema de Compras y Ventas POS";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(160, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 440);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem4});
            this.menuStrip3.Location = new System.Drawing.Point(0, 489);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(909, 30);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(159, 24);
            this.iconMenuItem4.Text = "TRANSACCIONES";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 49);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(260, 30);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MenuTitulo);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas POS";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuTitulo.ResumeLayout(false);
            this.MenuTitulo.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeComprasYVentasPOSToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem IconUsuario;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem IconCompras;
        private FontAwesome.Sharp.IconMenuItem IconVentas;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem IconProveedores;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}

