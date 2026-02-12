using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        
        {
            // Intentamos convertir el texto ingresado a un número entero
            if (int.TryParse(txtEntrada.Text, out int resultado))
            {
                // Si es un número válido
                MessageBox.Show("¡Correcto! Has ingresado el número: " + resultado,
                                "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si no es un número (contiene letras, símbolos o está vacío)
                MessageBox.Show("Error: Por favor, ingresa solo números.",
                                "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtEntrada.Clear(); // Limpia la caja para reintentar
                txtEntrada.Focus(); // Pone el cursor de nuevo en la caja
            }
        }

    }
}

