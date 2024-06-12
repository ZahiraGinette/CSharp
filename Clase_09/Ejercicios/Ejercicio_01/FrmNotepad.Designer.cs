namespace Ejercicio_01
{
    partial class FrmNotepad
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
            this.MenuStripArchivo = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtxtContenido = new System.Windows.Forms.RichTextBox();
            this.MenuStripArchivo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripArchivo
            // 
            this.MenuStripArchivo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.MenuStripArchivo.Location = new System.Drawing.Point(0, 0);
            this.MenuStripArchivo.Name = "MenuStripArchivo";
            this.MenuStripArchivo.Size = new System.Drawing.Size(362, 28);
            this.MenuStripArchivo.TabIndex = 0;
            this.MenuStripArchivo.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbrirToolStripMenuItem,
            this.GuardarToolStripMenuItem,
            this.GuardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // AbrirToolStripMenuItem
            // 
            this.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem";
            this.AbrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AbrirToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.AbrirToolStripMenuItem.Text = "Abrir";
            this.AbrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // GuardarToolStripMenuItem
            // 
            this.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem";
            this.GuardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.GuardarToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.GuardarToolStripMenuItem.Text = "Guardar";
            this.GuardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // GuardarComoToolStripMenuItem
            // 
            this.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem";
            this.GuardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.GuardarComoToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.GuardarComoToolStripMenuItem.Text = "Guardar como...";
            this.GuardarComoToolStripMenuItem.Click += new System.EventHandler(this.GuardarComoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(362, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(149, 20);
            this.toolStripStatusLabel.Text = "Total de caracteres: 0";
            // 
            // rtxtContenido
            // 
            this.rtxtContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtContenido.Location = new System.Drawing.Point(0, 28);
            this.rtxtContenido.Name = "rtxtContenido";
            this.rtxtContenido.Size = new System.Drawing.Size(362, 292);
            this.rtxtContenido.TabIndex = 2;
            this.rtxtContenido.Text = "";
            this.rtxtContenido.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // FrmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 346);
            this.Controls.Add(this.rtxtContenido);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MenuStripArchivo);
            this.MainMenuStrip = this.MenuStripArchivo;
            this.Name = "FrmNotepad";
            this.Text = "Notepad";
            this.MenuStripArchivo.ResumeLayout(false);
            this.MenuStripArchivo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripArchivo;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarComoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.RichTextBox rtxtContenido;
    }
}

