namespace rango__Inicio_y_Fin_
{
    partial class Form1
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
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lstPrimos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(44, 84);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(100, 22);
            this.txtInicio.TabIndex = 0;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(186, 84);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(100, 22);
            this.txtFin.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Cyan;
            this.btnGenerar.Location = new System.Drawing.Point(553, 260);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 66);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "clik";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lstPrimos
            // 
            this.lstPrimos.FormattingEnabled = true;
            this.lstPrimos.ItemHeight = 16;
            this.lstPrimos.Location = new System.Drawing.Point(53, 122);
            this.lstPrimos.Name = "lstPrimos";
            this.lstPrimos.Size = new System.Drawing.Size(158, 292);
            this.lstPrimos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPrimos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.txtInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox lstPrimos;
    }
}

