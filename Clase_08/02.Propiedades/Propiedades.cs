using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.Propiedades
{
    public partial class Propiedades : Form
    {
        public Propiedades()
        {
            InitializeComponent();

            this.btnBotonDos.ForeColor = Color.Coral;
 

            // Name
            this.Name = "FormularioPrincipal"; // Indica el nombre utilizado en el código para identificar el objeto.

            // BackColor
            this.BackColor = Color.LightBlue; // Indica el color de fondo del componente o formulario

            // Cursor
            this.Cursor = Cursors.Hand; // Indica el cursor que aparece al pasar el puntero por el control.

            // Enabled
            this.Enabled = true; // Indica si el control está habilitado.

            // Font
            this.Font = new Font("Arial", 12, FontStyle.Bold); // Fuente utilizada para mostrar el texto en el control.

            // ForeColor
            this.ForeColor = Color.DarkBlue; // Color utilizado para mostrar texto.

            // Locked
            this.ControlBox = false; // Se bloquea el uso de los controles del formulario (no se puede cerrar/minimizar/maximizar)
  
            // TabIndex
            this.TabIndex = 1; // Índice de tabulación para el formulario

            // Text
            this.Text = "Bienvenido a mi Formulario de propiedades"; // Texto que se muestra en la barra de título del formulario

            // Visible
            this.Visible = true; // Determina si el formulario es visible u oculto

            // BackgroundImage
            // this.BackgroundImage = Image.FromFile("ruta/de/tu/imagen.jpg"); // Imagen de fondo del formulario
            // this.BackgroundImageLayout = ImageLayout.Stretch; // Cómo se ajusta la imagen de fondo al formulario

            // StartPosition
            // this.StartPosition = FormStartPosition.CenterScreen; // El formulario aparece en el centro de la pantalla al abrirse

            // Icon
           // this.Icon = new Icon("ruta/de/tu/icono.ico"); // Icono del formulario

        }
    }
}
