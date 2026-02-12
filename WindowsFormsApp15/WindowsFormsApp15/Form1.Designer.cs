namespace WindowsFormsApp20
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
            this.pestañasPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTab2 = new System.Windows.Forms.Label();
            this.lblTab1 = new System.Windows.Forms.Label();
            this.pestañasPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pestañasPrincipal
            // 
            this.pestañasPrincipal.Controls.Add(this.tabPage1);
            this.pestañasPrincipal.Controls.Add(this.tabPage2);
            this.pestañasPrincipal.Location = new System.Drawing.Point(34, 39);
            this.pestañasPrincipal.Name = "pestañasPrincipal";
            this.pestañasPrincipal.SelectedIndex = 0;
            this.pestañasPrincipal.Size = new System.Drawing.Size(648, 310);
            this.pestañasPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Información Personal";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTab2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles de Contacto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTab2
            // 
            this.lblTab2.AutoSize = true;
            this.lblTab2.Location = new System.Drawing.Point(29, 24);
            this.lblTab2.Name = "lblTab2";
            this.lblTab2.Size = new System.Drawing.Size(238, 16);
            this.lblTab2.TabIndex = 0;
            this.lblTab2.Text = "\"Aquí encontrarás el correo y teléfono.\"";
            // 
            // lblTab1
            // 
            this.lblTab1.AutoSize = true;
            this.lblTab1.Location = new System.Drawing.Point(44, 25);
            this.lblTab1.Name = "lblTab1";
            this.lblTab1.Size = new System.Drawing.Size(214, 16);
            this.lblTab1.TabIndex = 0;
            this.lblTab1.Text = "\"Bienvenido a la sección de perfil.\"";
            this.lblTab1.Click += new System.EventHandler(this.lblTab1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pestañasPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pestañasPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pestañasPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTab1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTab2;
    }
}

