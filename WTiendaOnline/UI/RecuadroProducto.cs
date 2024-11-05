using System;
using System.Windows.Forms;


namespace WTiendaOnline.UI
{
    public partial class RecuadroProducto : UserControl
    {
        private readonly Login _Login;
        public RecuadroProducto()
        {
            InitializeComponent();

            _Login = new Login();
        }

        private void panProducto_Click(object sender, EventArgs e)
        {
            ProductoSelecionado();
        }

        private void ProductoSelecionado()
        {
            Controls.Add(_Login);
        }
    }
}
