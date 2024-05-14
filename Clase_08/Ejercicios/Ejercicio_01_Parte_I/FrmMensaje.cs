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
    public partial class FrmMensaje : Form
    {
        public FrmMensaje(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }
    }
}
