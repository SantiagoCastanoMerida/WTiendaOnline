using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace WTiendaOnline
{
    public partial class Inicio : Form
    {
        private readonly UI.Login _login;
        private readonly UI.Registro _registro;
        private readonly UI.HeaderLogin _headerLogin;
        private readonly UI.HeaderTienda _headerTienda;
        private readonly UI.Productos _productos;
        private readonly UI.ProductoSelecionado _productoSelecionado;
        private readonly UI.RecuadroProducto _recuadroProducto;
        private readonly UI.CarritoDeCompras _carritoDeCompras;
        private readonly UI.Contactanos _contactanos;
        public Inicio()
        {
            InitializeComponent();

            //CargarComponentes
            _login = new UI.Login();
            _registro = new UI.Registro();
            _headerLogin = new UI.HeaderLogin();
            _headerTienda = new UI.HeaderTienda();
            _productos = new UI.Productos();
            _productoSelecionado = new UI.ProductoSelecionado();
            _recuadroProducto = new UI.RecuadroProducto();
            _carritoDeCompras = new UI.CarritoDeCompras();
            _contactanos = new UI.Contactanos();

            //Agregar evento Navigate
            _login.OnNavigate += Navegar;
            _registro.OnNavigate += Navegar;
            _headerTienda.OnNavigate += Navegar;
            

            //Cargar panel principal
            Controls.Add(_headerLogin);
            Controls.Add(_login);

        }

        //Ver panel a cargar
        private void Navegar(string panelRuta)
        {
            UserControl panel;

            switch (panelRuta)
            {
                case "Registro":
                    panel = _registro;
                    break;
                case "Login":
                    panel = _login;
                    break;
                case "Productos":
                    panel = _productos;
                    break;
                case "ProductoSelecionado":
                    panel = _productoSelecionado;
                    break;
                case "CarritoDeCompras":
                    panel = _carritoDeCompras;
                    break;
                case "Contactanos":
                    panel = _contactanos;
                    break;
                default:
                    panel = _login;
                    break;
            }
            Cargar(panel);

        }

        //limpiar y cargar paneles
        private void Cargar(UserControl panel)
        {
            if (panel == _productoSelecionado) 
            {
                Controls.Add(_login);
                return;
            }
            Controls.Clear();
            
            if (panel == _login || panel == _registro)
            {
                Controls.Add(_headerLogin);
            }
            else
            {
                Controls.Add(_headerTienda);
            }
            Controls.Add(panel);
        }
    }
}
