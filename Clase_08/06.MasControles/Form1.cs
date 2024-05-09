using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06.MasControles
{
    public partial class Form1 : Form
    {
        private Button buttonMostrar;
        private TextBox textBoxEntrada;
        private Label labelInstruccion;
 
        public Form1()
        {
            InitializeComponent(); 
             
            labelInstruccion = new Label();
            labelInstruccion.Text = "Nombre:";
            labelInstruccion.Location = new Point(10, 10);
            labelInstruccion.AutoSize = true;  
             
            textBoxEntrada = new TextBox();
            textBoxEntrada.Location = new Point(10, 40);
            textBoxEntrada.Width = 200;  
             
            buttonMostrar = new Button();
            buttonMostrar.Text = "Aceptar";
            buttonMostrar.Location = new Point(10, 70);
            buttonMostrar.Click += ButtonMostrar_Click;  
             
            this.Controls.Add(labelInstruccion);
            this.Controls.Add(textBoxEntrada);
            this.Controls.Add(buttonMostrar);
        }

        private void ButtonMostrar_Click(object sender, EventArgs e)
        { 
            string textoIngresado = textBoxEntrada.Text;  
            MessageBox.Show("El nombre ingresado es: " + textoIngresado);  
        }
    }
}
