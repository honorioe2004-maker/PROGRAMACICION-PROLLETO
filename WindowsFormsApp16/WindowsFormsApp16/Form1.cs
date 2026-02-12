using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        
        {
            // Usamos el nombre completo: System.IO.File
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Esto le dice a Visual Studio exactamente dónde buscar el comando File
                System.IO.File.WriteAllText(saveFileDialog1.FileName, txtContenido.Text);

                MessageBox.Show("¡Guardado correctamente!", "Aviso");
            }
        }

    }
}

