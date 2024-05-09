using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03.Metodos
{
    public partial class PrimerFormulario : Form
    {
        public PrimerFormulario()
        {
            InitializeComponent();

            this.Text = "Primer formulario";

            // Agregamos botones para demostrar diferentes métodos
            Button btnShow = new Button();
            btnShow.Text = "Mostrar Segundo Formulario";
            btnShow.Location = new Point(10, 10);
            btnShow.Click += BtnShow_Click; // Mostrar el segundo formulario con Show()

            Button btnShowDialog = new Button();
            btnShowDialog.Text = "Mostrar como diálogo";
            btnShowDialog.Location = new Point(10, 50);
            btnShowDialog.Click += BtnShowDialog_Click; // Mostrar como cuadro de diálogo modal

            Button btnHide = new Button();
            btnHide.Text = "Ocultar este formulario";
            btnHide.Location = new Point(10, 90);
            btnHide.Click += BtnHide_Click; // Ocultar el formulario actual

            // Agregar botones al formulario
            this.Controls.Add(btnShow);
            this.Controls.Add(btnShowDialog);
            this.Controls.Add(btnHide); 
             
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el segundo formulario usando Show()
            MiTercerFormulario formularioNuevo = new MiTercerFormulario();
            formularioNuevo.Show(); // Muestra el formulario de forma no modal
        }

        private void BtnShowDialog_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el segundo formulario como un cuadro de diálogo modal
            SegundoFormulario segundoForm = new SegundoFormulario();
            segundoForm.ShowDialog(); // Muestra el formulario de forma modal
        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
            // Ocultar este formulario
            this.Hide(); // El formulario actual se oculta
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Cerrar este formulario
            this.Close(); // El formulario actual se cierra
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
