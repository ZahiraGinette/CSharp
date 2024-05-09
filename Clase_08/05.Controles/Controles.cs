using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05.Controles
{
    public partial class Controles : Form
    {
        public Controles()
        {
            InitializeComponent();

            this.Text = "Formulario de controles";

            TextBox textBox = new TextBox();
            textBox.Text = "Mi textbox";
            textBox.Location = new Point(5, 59);
            textBox.TabIndex = 0;

            TextBox textBoxDos = new TextBox();
            textBoxDos.Text = "Mi segundo textbox";
            textBoxDos.Location = new Point(6, 80);
            textBoxDos.TabIndex = 0;                                                           

            this.Controls.Add(textBox);
            this.Controls.Add(textBoxDos);

        }
    }
}
