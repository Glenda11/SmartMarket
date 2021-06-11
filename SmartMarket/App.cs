using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMarket
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            CrearCuenta crear = new CrearCuenta();
            crear.Show();

            Close();
        }

        private void App_Load(object sender, EventArgs e)
        {
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.Show();

            Close();
        }
    }
}
