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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();

            Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtBoxNumero.Text))
            {
                MessageBox.Show("Ingrese un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtBoxNumero.Text.Length != 8)
            {
                MessageBox.Show("El número debe tener 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
