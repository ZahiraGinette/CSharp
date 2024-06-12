using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class FrmNotepad : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private string archivo;

        private string Archivo
        {
            get
            {
                return archivo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    archivo = value;
                }
            }
        }

        public FrmNotepad()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto|*.txt";
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = $"Total de caracteres: {rtxtContenido.Text.Length}";
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivo = openFileDialog.FileName;
                using (StreamReader streamReader = new StreamReader(archivo))
                {
                    rtxtContenido.Text = streamReader.ReadToEnd();
                }
            }
        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo = SeleccionarUbicacionGuardado();

            GuardarArchivo(Archivo);
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Archivo))
            {
                Archivo = SeleccionarUbicacionGuardado();
            }

            GuardarArchivo(Archivo);
        }

        private string SeleccionarUbicacionGuardado()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return string.Empty;
        }

        private void GuardarArchivo(string ruta)
        {
            if (!string.IsNullOrWhiteSpace(ruta))
            {
                using (StreamWriter streamWriter = new StreamWriter(archivo))
                {
                    streamWriter.Write(rtxtContenido.Text);
                }
            }
        }
    }
}
