using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuantas_palabras_contiene
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void btnContar_Click(object sender, EventArgs e)
        {
            string texto = txtOracion.Text.Trim();

            if (!string.IsNullOrEmpty(texto))
            {
                string[] palabras = texto.Split(' ');
                lblCantidad.Text = "Cantidad de palabras: " + palabras.Length;
            }
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }
    }
    }

