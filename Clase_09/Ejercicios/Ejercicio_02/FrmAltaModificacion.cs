using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02
{
    public partial class FrmAltaModificacion : Form
    {
        public string Objeto
        {
            get
            {
                return txtObjeto.Text;
            }
        }

        public FrmAltaModificacion(string titulo, string textoTxtObjeto, string textoBtnConfirmar)
        {
            InitializeComponent();
            this.Text = titulo;
            txtObjeto.Text = textoTxtObjeto;
            btnConfirmar.Text = textoBtnConfirmar;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Validar();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void Validar()
        {
            if (string.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                MessageBox.Show("El campo no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
