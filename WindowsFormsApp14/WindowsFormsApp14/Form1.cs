using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        
        {
            // Si la barra no ha llegado al máximo (100)
            if (pbProgreso.Value < 100)
            {
                pbProgreso.Value += 1; // Aumenta de 1 en 1
            }
            else
            {
                tiempo.Stop(); // Se detiene al llegar al final
                MessageBox.Show("¡Proceso Completado!");
            }
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {

        }
    }
}

