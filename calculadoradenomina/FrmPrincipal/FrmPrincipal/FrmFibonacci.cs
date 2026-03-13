using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class FrmFibonacci : Form
    {
        public FrmFibonacci()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        
        {
            // Validar que el texto sea un número entero válido
            if (!int.TryParse(txtLimite.Text, out int limite))
            {
                // Mostrar mensaje de error si la entrada es inválida
                MessageBox.Show("Por favor, ingresa un número entero válido en el campo límite.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLimite.Focus(); // Devolver el foco al campo para corregir
                return; // Salir del método si hay error
            }

            int a = 0, b = 1;
            txtResultado.Clear();

            while (a <= limite)
            {
                txtResultado.AppendText(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
    }

