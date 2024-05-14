namespace Ejercicio_03
{
    partial class FrmDescuento
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
            this.GroupBoxInformacion = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.GroupBoxInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxInformacion
            // 
            this.GroupBoxInformacion.Controls.Add(this.txtTotal);
            this.GroupBoxInformacion.Controls.Add(this.lblTotal);
            this.GroupBoxInformacion.Controls.Add(this.txtDescuento);
            this.GroupBoxInformacion.Controls.Add(this.lblDescuento);
            this.GroupBoxInformacion.Controls.Add(this.txtImporte);
            this.GroupBoxInformacion.Controls.Add(this.lblImporte);
            this.GroupBoxInformacion.Location = new System.Drawing.Point(12, 21);
            this.GroupBoxInformacion.Name = "GroupBoxInformacion";
            this.GroupBoxInformacion.Size = new System.Drawing.Size(383, 147);
            this.GroupBoxInformacion.TabIndex = 0;
            this.GroupBoxInformacion.TabStop = false;
            this.GroupBoxInformacion.Text = "Información";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(244, 105);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(123, 22);
            this.txtTotal.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(98, 108);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(106, 17);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total a pagar";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(244, 77);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(123, 22);
            this.txtDescuento.TabIndex = 3;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(74, 80);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(130, 17);
            this.lblDescuento.TabIndex = 2;
            this.lblDescuento.Text = "Descuento recibido";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(244, 36);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(123, 22);
            this.txtImporte.TabIndex = 1;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(11, 36);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(193, 18);
            this.lblImporte.TabIndex = 0;
            this.lblImporte.Text = "Ingrese importe a cobrar";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(212, 174);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(111, 46);
            this.BtnLimpiar.TabIndex = 2;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(75, 174);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(111, 46);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 238);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.GroupBoxInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuento";
            this.GroupBoxInformacion.ResumeLayout(false);
            this.GroupBoxInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxInformacion;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAceptar;
    }
}

