namespace primo
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
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.btnPrimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(38, 28);
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(100, 22);
            this.mtxtNumero.TabIndex = 0;
            // 
            // btnPrimo
            // 
            this.btnPrimo.BackColor = System.Drawing.Color.Cyan;
            this.btnPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimo.Location = new System.Drawing.Point(438, 172);
            this.btnPrimo.Name = "btnPrimo";
            this.btnPrimo.Size = new System.Drawing.Size(148, 119);
            this.btnPrimo.TabIndex = 1;
            this.btnPrimo.Text = "clik";
            this.btnPrimo.UseVisualStyleBackColor = false;
            this.btnPrimo.Click += new System.EventHandler(this.btnPrimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrimo);
            this.Controls.Add(this.mtxtNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.Button btnPrimo;
    }
}

