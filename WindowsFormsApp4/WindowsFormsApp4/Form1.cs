using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
            // 1. Declaramos la variable fuera de la función para que no se borre
            int contador = 0;

private void btnPresionar_Click(object sender, EventArgs e)
        {
            // 2. Aumentamos el número
            contador++;

            // 3. Mostramos el resultado en la etiqueta (identificada como lblConteo)
            lblConteo.Text = contador.ToString();
        }

    }
}

