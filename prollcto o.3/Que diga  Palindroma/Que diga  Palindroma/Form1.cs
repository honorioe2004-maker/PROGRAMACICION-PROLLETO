using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Que_diga__Palindroma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
            private void btnVerificar_Click(object sender, EventArgs e)
        {
            // 1. Limpieza: quitamos espacios y pasamos a minúsculas
            string textoLimpio = txtPalabra.Text.Replace(" ", "").ToLower();

            // Validar que no esté vacío
            if (string.IsNullOrWhiteSpace(textoLimpio))
            {
                MessageBox.Show("Por favor, escribe algo primero.", "Atención");
                return;
            }

            // 2. Invertir la cadena
            char[] array = textoLimpio.ToCharArray();
            Array.Reverse(array);
            string textoInvertido = new string(array);

            // 3. Comparación y Mensaje
            if (textoLimpio == textoInvertido)
            {
                MessageBox.Show($"'{txtPalabra.Text}' es palíndroma. ✅", "Resultado");
            }
            else
            {
                MessageBox.Show($"'{txtPalabra.Text}' NO es palíndroma. ❌", "Resultado");
            }

            // Opcional: Limpiar y preparar para la siguiente palabra
            txtPalabra.Clear();
            txtPalabra.Focus();
        }

    }
}

