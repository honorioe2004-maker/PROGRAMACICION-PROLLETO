namespace FrmPrincipal
{
    partial class FrmDivisas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbA = new System.Windows.Forms.ComboBox();
            this.cmbDe = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(67, 177);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 0;
            // 
            // cmbA
            // 
            this.cmbA.FormattingEnabled = true;
            this.cmbA.Location = new System.Drawing.Point(67, 118);
            this.cmbA.Name = "cmbA";
            this.cmbA.Size = new System.Drawing.Size(121, 24);
            this.cmbA.TabIndex = 1;
            // 
            // cmbDe
            // 
            this.cmbDe.FormattingEnabled = true;
            this.cmbDe.Location = new System.Drawing.Point(67, 52);
            this.cmbDe.Name = "cmbDe";
            this.cmbDe.Size = new System.Drawing.Size(121, 24);
            this.cmbDe.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 90);
            this.button1.TabIndex = 3;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(67, 251);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(76, 16);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultados";
            // 
            // FrmDivisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbDe);
            this.Controls.Add(this.cmbA);
            this.Controls.Add(this.txtCantidad);
            this.Name = "FrmDivisas";
            this.Text = "FrmDivisas";
            this.Load += new System.EventHandler(this.FrmDivisas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbA;
        private System.Windows.Forms.ComboBox cmbDe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultado;
    }
}