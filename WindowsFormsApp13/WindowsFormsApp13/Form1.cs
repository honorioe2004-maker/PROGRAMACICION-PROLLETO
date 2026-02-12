using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
       
        {
            // 1. Intentamos obtener el número de la caja de texto
            // Usamos 'double' para permitir decimales (ej. 25.5 grados)
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                // 2. Aplicamos la fórmula matemática
                double fahrenheit = (celsius * 9 / 5) + 32;

                // 3. Mostramos el resultado formateado en la etiqueta
                // El ":F2" sirve para mostrar solo 2 decimales
                lblResultado.Text = string.Format("Resultado: {0:F2} °F", fahrenheit);

                // Cambiamos el color a azul para indicar éxito
                lblResultado.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                // 4. Si el usuario escribió letras en lugar de números
                MessageBox.Show("Por favor, ingrese un valor numérico válido.",
                                "Error de entrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtCelsius.Clear();
                txtCelsius.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
