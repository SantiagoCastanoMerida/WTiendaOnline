using System;
using System.Windows.Forms;

namespace WTiendaOnline.UI
{
    public partial class Productos : UserControl
    {
        public event Action<string> OnNavigate;
        public Productos()
        {
            InitializeComponent();
        }
    }
}
