using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
       
        {
            // Validamos que sea un número para evitar que el programa se cierre (crash)
            if (int.TryParse(txtNumero.Text, out int num))
            {
                lstTabla.Items.Clear(); // Limpiamos antes de empezar
                for (int i = 1; i <= 12; i++)
                {
                    lstTabla.Items.Add($"{num} x {i} = {num * i}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

    }
}

