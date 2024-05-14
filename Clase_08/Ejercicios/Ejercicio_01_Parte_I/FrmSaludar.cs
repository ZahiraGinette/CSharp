using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01_Parte_I
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            string mensaje = $"Soy {txtNombre.Text} {txtApellido.Text}.";

            FrmMensaje frmMensaje = new FrmMensaje(mensaje);
            frmMensaje.ShowDialog();
        }
    }
}
