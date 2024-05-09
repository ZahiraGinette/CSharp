namespace _02.Propiedades
{
    partial class Propiedades
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBotonDos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mi formulario de propiedades";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.BackColor = System.Drawing.Color.Gold;
            this.lblLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabel.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.Location = new System.Drawing.Point(12, 57);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(94, 44);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.Text = "Hola";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(12, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnBotonDos
            // 
            this.btnBotonDos.Enabled = false;
            this.btnBotonDos.Location = new System.Drawing.Point(18, 181);
            this.btnBotonDos.Name = "btnBotonDos";
            this.btnBotonDos.Size = new System.Drawing.Size(75, 23);
            this.btnBotonDos.TabIndex = 3;
            this.btnBotonDos.Text = "button2";
            this.btnBotonDos.UseVisualStyleBackColor = true;
            // 
            // Propiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(462, 368);
            this.Controls.Add(this.btnBotonDos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.label1);
            this.Name = "Propiedades";
            this.Text = "Mi form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBotonDos;
    }
}

