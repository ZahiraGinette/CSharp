using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04.MessageShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto es un mensaje!");
            MessageBox.Show("Algo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje","Informe",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
        }
    }
}
