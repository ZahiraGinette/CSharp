using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Ejercicio_02
{
    public partial class FrmRegistro : Form
    {
        private List<Curso> cursos;
        private EGenero genero;

        public FrmRegistro()
        {
            InitializeComponent();
            cursos = new List<Curso>();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            listBoxPais.Items.Add("Argentina");
            listBoxPais.Items.Add("Chile");
            listBoxPais.Items.Add("Uruguay");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Ingresante ingresante = new Ingresante(txtNombre.Text, (int)numEdad.Value, genero, txtDireccion.Text, listBoxPais.Text, cursos);
                FrmMensaje frmMensaje = new FrmMensaje(ingresante.Mostrar());
                frmMensaje.ShowDialog();
            }
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            Curso curso = new Curso(checkBox.Text);

            if (checkBox.Checked)
            {
                cursos.Add(curso);
            }
            else
            {
                cursos.Remove(curso);
            } 
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton.Checked)
            {
                if (radioButton == RadioMasculino)
                {
                    genero = EGenero.Masculino;
                }
                else if (radioButton == RadioFemenino)
                {
                    genero = EGenero.Femenino;
                }
                else if (radioButton == RadioNoBinario)
                {
                    genero = EGenero.NoBinario;
                }
            }
        }

        private bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:\n");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Dirección");
            }

            if ((int)numEdad.Value == 0)
            {
                esValido = false;
                stringBuilder.AppendLine("Edad");
            }

            if (string.IsNullOrWhiteSpace(listBoxPais.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("País");
            }

            if (cursos.Count == 0)
            {
                esValido = false;
                stringBuilder.AppendLine("Curso/s");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }
    }
}
