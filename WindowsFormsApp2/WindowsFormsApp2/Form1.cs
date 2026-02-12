using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Si este evento aparece con error, es porque no está vinculado en el Diseñador
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Bienvenida/o al formulario de Elias matricula LR 2025 02827", "Mensaje de Bienvenida");
        }

      
        

        }
    }

