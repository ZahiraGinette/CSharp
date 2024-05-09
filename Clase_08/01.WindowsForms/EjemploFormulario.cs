using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01.Windows_forms
{
    public partial class EjemploFormulario : Form
    {
        public EjemploFormulario()
        {
            InitializeComponent();

            // Conectar eventos con métodos
            this.Load += EjemploFormulario_Load;
            this.Paint += EjemploFormulario_Paint;
            this.Activated += EjemploFormulario_Activated;
            this.FormClosing += EjemploFormulario_FormClosing;
            this.FormClosed += EjemploFormulario_FormClosed;
            this.Disposed += EjemploFormulario_Disposed;
        }

        private void EjemploFormulario_Load(object sender, EventArgs e)
        {
            // Cargar datos iniciales o configurar el formulario
        }

        private void EjemploFormulario_Paint(object sender, PaintEventArgs e)
        {
            // Dibujar un círculo rojo en el formulario
            e.Graphics.FillEllipse(Brushes.Red, 10, 10, 50, 50);
        }

        private void EjemploFormulario_Activated(object sender, EventArgs e)
        {
            // Realizar acciones cuando el formulario se activa
        }

        private void EjemploFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            // Preguntar si el usuario realmente quiere cerrar
            var result = MessageBox.Show("¿Desea cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancelar el cierre
            }
        }

        private void EjemploFormulario_FormClosed(object sender, FormClosedEventArgs e)
        { 
        }

        private void EjemploFormulario_Disposed(object sender, EventArgs e)
        {
            
        }
    }
}
