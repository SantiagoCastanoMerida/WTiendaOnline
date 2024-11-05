namespace WTiendaOnline.UI
{
    partial class Productos
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
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.recuadroProducto1 = new WTiendaOnline.UI.RecuadroProducto();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(20, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(147, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Resultado";
            // 
            // recuadroProducto1
            // 
            this.recuadroProducto1.Location = new System.Drawing.Point(20, 73);
            this.recuadroProducto1.Name = "recuadroProducto1";
            this.recuadroProducto1.Size = new System.Drawing.Size(166, 136);
            this.recuadroProducto1.TabIndex = 1;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.recuadroProducto1);
            this.Controls.Add(this.lblTitulo);
            this.Location = new System.Drawing.Point(0, 70);
            this.MinimumSize = new System.Drawing.Size(900, 480);
            this.Name = "Productos";
            this.Size = new System.Drawing.Size(900, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private RecuadroProducto recuadroProducto1;
    }
}
