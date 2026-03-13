namespace FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversorDivisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroPersonaToolStripMenuItem,
            this.conversorDivisasToolStripMenuItem,
            this.serieFibonacciToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.opcionesToolStripMenuItem.Text = "opciones";
            // 
            // registroPersonaToolStripMenuItem
            // 
            this.registroPersonaToolStripMenuItem.Name = "registroPersonaToolStripMenuItem";
            this.registroPersonaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registroPersonaToolStripMenuItem.Text = "Registro Persona";
            this.registroPersonaToolStripMenuItem.Click += new System.EventHandler(this.registroPersonaToolStripMenuItem_Click);
            // 
            // conversorDivisasToolStripMenuItem
            // 
            this.conversorDivisasToolStripMenuItem.Name = "conversorDivisasToolStripMenuItem";
            this.conversorDivisasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.conversorDivisasToolStripMenuItem.Text = "Conversor Divisas";
            this.conversorDivisasToolStripMenuItem.Click += new System.EventHandler(this.conversorDivisasToolStripMenuItem_Click);
            // 
            // serieFibonacciToolStripMenuItem
            // 
            this.serieFibonacciToolStripMenuItem.Name = "serieFibonacciToolStripMenuItem";
            this.serieFibonacciToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serieFibonacciToolStripMenuItem.Text = "Serie Fibonacci";
            this.serieFibonacciToolStripMenuItem.Click += new System.EventHandler(this.serieFibonacciToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema de Formularios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversorDivisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieFibonacciToolStripMenuItem;
    }
}

