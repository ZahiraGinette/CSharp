using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_03
{
    public partial class FrmDescuento : Form
    {
        public FrmDescuento()
        {
            InitializeComponent();
            txtDescuento.Enabled = false;
            txtTotal.Enabled = false;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int importe = Int32.Parse(txtImporte.Text);
            double descuento = 0;
            double total = 0;

            if (importe >= 3000 && importe <= 5000)
            {
                descuento = importe * 0.10;
                txtDescuento.Text = descuento.ToString();
                total = importe - descuento;
                txtTotal.Text = total.ToString();
            }
            else if (importe > 5000)
            {
                descuento = importe * 0.20;
                txtDescuento.Text = descuento.ToString();
                total = importe - descuento;
                txtTotal.Text = total.ToString();
            }else
            {
                txtDescuento.Text = "0";
                txtTotal.Text = importe.ToString();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control item in control.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;
                        }
                    }
                }
            }
        }
    }
}
