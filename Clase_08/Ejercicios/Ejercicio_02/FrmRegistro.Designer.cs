namespace Ejercicio_02
{
    partial class FrmRegistro
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
            this.grBoxUsuario = new System.Windows.Forms.GroupBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.GruopBoxGenero = new System.Windows.Forms.GroupBox();
            this.RadioNoBinario = new System.Windows.Forms.RadioButton();
            this.RadioFemenino = new System.Windows.Forms.RadioButton();
            this.RadioMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckBoxJavaScript = new System.Windows.Forms.CheckBox();
            this.CheckBoxCMasMas = new System.Windows.Forms.CheckBox();
            this.CheckBoxC = new System.Windows.Forms.CheckBox();
            this.listBoxPais = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grBoxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.GruopBoxGenero.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxUsuario
            // 
            this.grBoxUsuario.Controls.Add(this.numEdad);
            this.grBoxUsuario.Controls.Add(this.lblEdad);
            this.grBoxUsuario.Controls.Add(this.txtDireccion);
            this.grBoxUsuario.Controls.Add(this.lblDireccion);
            this.grBoxUsuario.Controls.Add(this.txtNombre);
            this.grBoxUsuario.Controls.Add(this.lblNombre);
            this.grBoxUsuario.Location = new System.Drawing.Point(12, 12);
            this.grBoxUsuario.Name = "grBoxUsuario";
            this.grBoxUsuario.Size = new System.Drawing.Size(241, 127);
            this.grBoxUsuario.TabIndex = 0;
            this.grBoxUsuario.TabStop = false;
            this.grBoxUsuario.Text = "Detalles de usuario";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(72, 95);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(163, 22);
            this.numEdad.TabIndex = 1;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 97);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(40, 16);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(72, 59);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(163, 22);
            this.txtDireccion.TabIndex = 2;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 59);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // GruopBoxGenero
            // 
            this.GruopBoxGenero.Controls.Add(this.RadioNoBinario);
            this.GruopBoxGenero.Controls.Add(this.RadioFemenino);
            this.GruopBoxGenero.Controls.Add(this.RadioMasculino);
            this.GruopBoxGenero.Location = new System.Drawing.Point(277, 12);
            this.GruopBoxGenero.Name = "GruopBoxGenero";
            this.GruopBoxGenero.Size = new System.Drawing.Size(116, 112);
            this.GruopBoxGenero.TabIndex = 6;
            this.GruopBoxGenero.TabStop = false;
            this.GruopBoxGenero.Text = "Género";
            // 
            // RadioNoBinario
            // 
            this.RadioNoBinario.AutoSize = true;
            this.RadioNoBinario.Location = new System.Drawing.Point(6, 73);
            this.RadioNoBinario.Name = "RadioNoBinario";
            this.RadioNoBinario.Size = new System.Drawing.Size(90, 20);
            this.RadioNoBinario.TabIndex = 2;
            this.RadioNoBinario.Text = "No binario";
            this.RadioNoBinario.UseVisualStyleBackColor = true;
            this.RadioNoBinario.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // RadioFemenino
            // 
            this.RadioFemenino.AutoSize = true;
            this.RadioFemenino.Location = new System.Drawing.Point(7, 47);
            this.RadioFemenino.Name = "RadioFemenino";
            this.RadioFemenino.Size = new System.Drawing.Size(88, 20);
            this.RadioFemenino.TabIndex = 1;
            this.RadioFemenino.Text = "Femenino";
            this.RadioFemenino.UseVisualStyleBackColor = true;
            this.RadioFemenino.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // RadioMasculino
            // 
            this.RadioMasculino.AutoSize = true;
            this.RadioMasculino.Checked = true;
            this.RadioMasculino.Location = new System.Drawing.Point(6, 21);
            this.RadioMasculino.Name = "RadioMasculino";
            this.RadioMasculino.Size = new System.Drawing.Size(89, 20);
            this.RadioMasculino.TabIndex = 0;
            this.RadioMasculino.TabStop = true;
            this.RadioMasculino.Text = "Masculino";
            this.RadioMasculino.UseVisualStyleBackColor = true;
            this.RadioMasculino.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckBoxJavaScript);
            this.groupBox2.Controls.Add(this.CheckBoxCMasMas);
            this.groupBox2.Controls.Add(this.CheckBoxC);
            this.groupBox2.Location = new System.Drawing.Point(277, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 112);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cursos";
            // 
            // CheckBoxJavaScript
            // 
            this.CheckBoxJavaScript.AutoSize = true;
            this.CheckBoxJavaScript.Location = new System.Drawing.Point(13, 75);
            this.CheckBoxJavaScript.Name = "CheckBoxJavaScript";
            this.CheckBoxJavaScript.Size = new System.Drawing.Size(93, 20);
            this.CheckBoxJavaScript.TabIndex = 13;
            this.CheckBoxJavaScript.Text = "JavaScript";
            this.CheckBoxJavaScript.UseVisualStyleBackColor = true;
            this.CheckBoxJavaScript.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // CheckBoxCMasMas
            // 
            this.CheckBoxCMasMas.AutoSize = true;
            this.CheckBoxCMasMas.Location = new System.Drawing.Point(13, 50);
            this.CheckBoxCMasMas.Name = "CheckBoxCMasMas";
            this.CheckBoxCMasMas.Size = new System.Drawing.Size(52, 20);
            this.CheckBoxCMasMas.TabIndex = 12;
            this.CheckBoxCMasMas.Text = "C++";
            this.CheckBoxCMasMas.UseVisualStyleBackColor = true;
            this.CheckBoxCMasMas.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // CheckBoxC
            // 
            this.CheckBoxC.AutoSize = true;
            this.CheckBoxC.Location = new System.Drawing.Point(13, 25);
            this.CheckBoxC.Name = "CheckBoxC";
            this.CheckBoxC.Size = new System.Drawing.Size(45, 20);
            this.CheckBoxC.TabIndex = 11;
            this.CheckBoxC.Text = "C#";
            this.CheckBoxC.UseVisualStyleBackColor = true;
            this.CheckBoxC.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // listBoxPais
            // 
            this.listBoxPais.FormattingEnabled = true;
            this.listBoxPais.ItemHeight = 16;
            this.listBoxPais.Location = new System.Drawing.Point(12, 170);
            this.listBoxPais.Name = "listBoxPais";
            this.listBoxPais.Size = new System.Drawing.Size(241, 84);
            this.listBoxPais.TabIndex = 11;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(12, 151);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 16);
            this.lblPais.TabIndex = 12;
            this.lblPais.Text = "País";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(277, 274);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(116, 32);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 321);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.listBoxPais);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GruopBoxGenero);
            this.Controls.Add(this.grBoxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.grBoxUsuario.ResumeLayout(false);
            this.grBoxUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.GruopBoxGenero.ResumeLayout(false);
            this.GruopBoxGenero.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxUsuario;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.GroupBox GruopBoxGenero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CheckBoxJavaScript;
        private System.Windows.Forms.CheckBox CheckBoxCMasMas;
        private System.Windows.Forms.CheckBox CheckBoxC;
        private System.Windows.Forms.ListBox listBoxPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.RadioButton RadioMasculino;
        private System.Windows.Forms.RadioButton RadioFemenino;
        private System.Windows.Forms.RadioButton RadioNoBinario;
    }
}

