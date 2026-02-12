using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            // MessageBox.Show es un método que pide parámetros separados por comas
            MessageBox.Show(
                "Hola, soy [Elias] y mi matrícula es [LR 2025 02827]", // El mensaje
                "Datos Personales",                                       // Título de la ventana
                MessageBoxButtons.OK,                                     // Botón de "Aceptar"
                MessageBoxIcon.Information                                // Icono azul de información
            );

        }
    }
}
