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
using System.Xml.Serialization;

namespace Ejercicio_02
{
    public partial class FrmListaSuper : Form
    {
        private List<string> listaSupermercado;
        private static string rutaArchivo;

        static FrmListaSuper()
        {
            string rutaApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            const string nombreArchivo = "listaSupermercado.xml";
            rutaArchivo = Path.Combine(rutaApplicationData, nombreArchivo);
        }

        public FrmListaSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            ConfigurarTooltips();
            RefrescarLista();
            CargarListaAlmacenada();
        }

        private void ConfigurarTooltips()
        {
            toolTipAgregar.SetToolTip(btnAgregar, "Agregar");
            toolTipEliminar.SetToolTip(btnEliminar, "Eliminar");
            toolTipModificar.SetToolTip(btnModificar, "Modificar");
        }

        private void RefrescarLista()
        {
            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaSupermercado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Agregar objeto", string.Empty, "Agregar");
            frmAltaModificacion.ShowDialog();

            if (frmAltaModificacion.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(frmAltaModificacion.Objeto);
                RefrescarLista();
                AlmacenarCambios();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = lstObjetos.SelectedItem as string;

            if (!String.IsNullOrEmpty(objetoSeleccionado))
            {
                listaSupermercado.Remove(objetoSeleccionado);
                RefrescarLista();
                AlmacenarCambios();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = lstObjetos.SelectedItem as string;

            if (!String.IsNullOrEmpty(objetoSeleccionado))
            {
                FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Modificar objeto", objetoSeleccionado, "Modificar");
                frmAltaModificacion.ShowDialog();

                if (frmAltaModificacion.DialogResult == DialogResult.OK)
                {
                    int indice = listaSupermercado.IndexOf(objetoSeleccionado);
                    listaSupermercado[indice] = frmAltaModificacion.Objeto;
                    RefrescarLista();
                    AlmacenarCambios();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarListaAlmacenada()
        {
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader streamReader = new StreamReader(rutaArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                    listaSupermercado = xmlSerializer.Deserialize(streamReader) as List<string>;
                }
            }
        }

        private void AlmacenarCambios()
        {
            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                xmlSerializer.Serialize(streamWriter, listaSupermercado);
            }
        }
    }
}
