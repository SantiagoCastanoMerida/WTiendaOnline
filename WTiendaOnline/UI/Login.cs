using System;
using System.Windows.Forms;

namespace WTiendaOnline.UI
{
    public partial class Login : UserControl
    {
        public event Action<string> OnNavigate;
        public Login()
        {
            InitializeComponent();

            //Inicializar componentes
            btnLogin.Text = "Iniciar Sesión";
            lblTituloLogin.Text = "Bienvenido a Clic&Shop";
            lblEmailLogin.Text = "Email";
            lblTelefonoLogin.Text = "Contraseña";
            lblRegistro.Text = "¿Ya tienes una cuenta?";
            hlkRegistro.Text = "Iniciar sesión";

        }
        //Buscar usuario en la base de datos
        private void btnLogin_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke("Productos");
        }

        //navegar a el Registro
        private void hlkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnNavigate?.Invoke("Registro");
        }

    }
}
