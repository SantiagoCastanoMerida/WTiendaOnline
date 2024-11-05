namespace WTiendaOnline.UI
{
    partial class RecuadroProducto
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
            this.panProducto = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPrecio = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.imgProducto = new System.Windows.Forms.PictureBox();
            this.panProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panProducto
            // 
            this.panProducto.BorderColor = System.Drawing.Color.Silver;
            this.panProducto.BorderThickness = 2;
            this.panProducto.Controls.Add(this.lblPrecio);
            this.panProducto.Controls.Add(this.imgProducto);
            this.panProducto.Location = new System.Drawing.Point(0, 0);
            this.panProducto.Name = "panProducto";
            this.panProducto.Size = new System.Drawing.Size(166, 136);
            this.panProducto.TabIndex = 2;
            this.panProducto.Click += new System.EventHandler(this.panProducto_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblPrecio.Location = new System.Drawing.Point(3, 109);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(51, 15);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // imgProducto
            // 
            this.imgProducto.Image = global::WTiendaOnline.Properties.Resources.Imagen_Prueba;
            this.imgProducto.Location = new System.Drawing.Point(2, 2);
            this.imgProducto.Name = "imgProducto";
            this.imgProducto.Size = new System.Drawing.Size(161, 100);
            this.imgProducto.TabIndex = 0;
            this.imgProducto.TabStop = false;
            // 
            // RecuadroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panProducto);
            this.Name = "RecuadroProducto";
            this.Size = new System.Drawing.Size(166, 136);
            this.panProducto.ResumeLayout(false);
            this.panProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panProducto;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrecio;
        private System.Windows.Forms.PictureBox imgProducto;
    }
}
