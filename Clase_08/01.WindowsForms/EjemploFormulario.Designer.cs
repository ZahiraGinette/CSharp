namespace _01.Windows_forms
{
    partial class EjemploFormulario 
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); 
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout(); //  detiene temporalmente la actualización del diseño del formulario
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Son propiedades que permiten que el formulario se ajuste automáticamente a diferentes resoluciones de pantalla
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Son propiedades que permiten que el formulario se ajuste automáticamente a diferentes resoluciones de pantalla
            this.ClientSize = new System.Drawing.Size(525, 387); // Determina el tamaño interno del formulario en pixeles
            this.Name = "EjemploFormulario"; // Nombre del formulario
            this.Text = "Mi primer formulario"; // Define el texto en la barra del titulo
            this.ResumeLayout(false); // reanuda el diseño, permitiendo que las modificaciones tomen efecto

        }

        #endregion
    }
}

