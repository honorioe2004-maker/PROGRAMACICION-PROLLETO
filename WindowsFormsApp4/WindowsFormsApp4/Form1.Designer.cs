namespace WindowsFormsApp8
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
            this.lblConteo = new System.Windows.Forms.Label();
            this.btnPresionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConteo
            // 
            this.lblConteo.AutoSize = true;
            this.lblConteo.Location = new System.Drawing.Point(39, 33);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(14, 16);
            this.lblConteo.TabIndex = 0;
            this.lblConteo.Text = "0";
            // 
            // btnPresionar
            // 
            this.btnPresionar.BackColor = System.Drawing.Color.Cyan;
            this.btnPresionar.Location = new System.Drawing.Point(437, 193);
            this.btnPresionar.Name = "btnPresionar";
            this.btnPresionar.Size = new System.Drawing.Size(189, 139);
            this.btnPresionar.TabIndex = 1;
            this.btnPresionar.Text = "Presióname.";
            this.btnPresionar.UseVisualStyleBackColor = false;
            this.btnPresionar.Click += new System.EventHandler(this.btnPresionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPresionar);
            this.Controls.Add(this.lblConteo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConteo;
        private System.Windows.Forms.Button btnPresionar;
    }
}

