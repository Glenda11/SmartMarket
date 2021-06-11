using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMarket
{
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG|*.jpg|PNG|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CambiarImagen(openFileDialog.FileName);
            }
        }

        private void CambiarImagen(string directorio)
        {
            Bitmap map = new Bitmap(directorio);
            pbImagen.Image = (Image)map;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();

            Close();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string imagen = pbImagen.ImageLocation;
            string nombre = txtBoxNombre.Text;
            string numero = txtBoxNumero.Text;
            string IP = ObtenerIP();
        }

        private string ObtenerIP()
        {
            IPHostEntry iPHostEntry = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress i in iPHostEntry.AddressList)
            {
                if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return i.ToString();
                }
            }

            return null;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtBoxNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtBoxNombre.Text.Length < 3)
            {
                MessageBox.Show("El nombre no puede contener menos de 3 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxNumero.Text))
            {
                MessageBox.Show("Ingrese un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtBoxNumero.Text.Length != 8)
            {
                MessageBox.Show("El numero debe de ser de 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
