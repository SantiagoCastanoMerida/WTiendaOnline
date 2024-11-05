using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTiendaOnline.UI
{
    public partial class Registro : UserControl
    {
        public event Action<string> OnNavigate;
        public Registro()
        {
            InitializeComponent();

            //Inicializar componentes
            btnRegistrarse.Text = "Registrarse";
            lblLogin.Text = "¿No tienes una cuenta?";
            lblTituloRegistro.Text = "Registrarse";
            lblNombreRegistro.Text = "Nombre";
            lblDireccionRegistro.Text = "Direccion";
            lblEmailRegistro.Text = "Email";
            lblTelefonoRegistro.Text = "Telefono";
            hlkLogin.Text = "Registrate";

        }
        //Realizar Registo en la base de datos
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            OnNavigate?.Invoke("Login");
        }

        //Navegar al login
        private void hlkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnNavigate?.Invoke("Login");
        }
    }
}
