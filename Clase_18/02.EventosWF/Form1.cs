using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.Eventos_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un evento pulsando el botón.");
        }

        private void btnMensaje_MouseHover(object sender, EventArgs e)
        {
             MessageBox.Show("Este es un evento MouseHover.");
        }

        private void btnMensaje_MouseDown(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("Este es un evento MouseDown.");
        }

        private void btnMensaje_MouseUp(object sender, MouseEventArgs e)
        {
            // MessageBox.Show("Este es un evento MouseUp.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMensaje_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnMensaje_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Este es un evento usando mouse click");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un evento pulsando el botón dos.");
        }
    }
}
