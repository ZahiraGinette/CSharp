using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09.ListBox
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent(); 
        }
         
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Tomar el texto del TextBox
            string texto = txtElemento.Text;

            if (!string.IsNullOrWhiteSpace(texto))
            {
                listBox.Items.Add(texto); // Agregar el texto al ListBox 
                txtElemento.Clear(); // Limpiar el TextBox después de agregar
                MessageBox.Show(listBox.Text);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un elemento antes de agregar.", "Error");
            }
        }
    }
}
