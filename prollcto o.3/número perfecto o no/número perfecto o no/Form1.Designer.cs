namespace número_perfecto_o_no
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
            this.btnPerfecto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(44, 25);
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(186, 22);
            this.mtxtNumero.TabIndex = 0;
            // 
            // btnPerfecto
            // 
            this.btnPerfecto.BackColor = System.Drawing.Color.Cyan;
            this.btnPerfecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfecto.Location = new System.Drawing.Point(86, 165);
            this.btnPerfecto.Name = "btnPerfecto";
            this.btnPerfecto.Size = new System.Drawing.Size(75, 77);
            this.btnPerfecto.TabIndex = 1;
            this.btnPerfecto.Text = "clik";
            this.btnPerfecto.UseVisualStyleBackColor = false;
            this.btnPerfecto.Click += new System.EventHandler(this.btnPerfecto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPerfecto);
            this.Controls.Add(this.mtxtNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.Button btnPerfecto;
    }
}

