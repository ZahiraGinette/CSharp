using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01_Parte_III
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        private void FrmSaludar_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Add("Acción");
            cmbGenero.Items.Add("Aventura");
            cmbGenero.Items.Add("Catástrofe");
            cmbGenero.Items.Add("Ciencia Ficción");
            cmbGenero.Items.Add("Comedia");
            cmbGenero.Items.Add("Documentales");
            cmbGenero.Items.Add("Drama");
            cmbGenero.Items.Add("Fantasía");
            cmbGenero.Items.Add("Musicales");
            cmbGenero.Items.Add("Suspense");
            cmbGenero.Items.Add("Terror");
            cmbGenero.SelectedIndex = 0;
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            string mensaje = $"Soy {txtNombre.Text} {txtApellido.Text} y mi género de película favorito es {cmbGenero.SelectedItem}.";

            if (Validar())
            {
                FrmMensaje frmMensaje = new FrmMensaje(mensaje);
                frmMensaje.ShowDialog();
            }
        }

        private bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:\n");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }
    }
}
