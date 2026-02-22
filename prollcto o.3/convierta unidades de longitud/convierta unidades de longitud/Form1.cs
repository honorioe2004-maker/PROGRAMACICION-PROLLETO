using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convierta_unidades_de_longitud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
            private void Form1_Load(object sender, EventArgs e)
        {
            cmbOrigen.Items.Add("Metros");
            cmbOrigen.Items.Add("Centímetros");
            cmbOrigen.Items.Add("Pulgadas");

            cmbDestino.Items.Add("Metros");
            cmbDestino.Items.Add("Centímetros");
            cmbDestino.Items.Add("Pulgadas");
        }

       
            private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValor.Text, out double valor))
            {
                double metros = 0;

                // PASO 1: Convertir todo a metros
                if (cmbOrigen.Text == "Metros")
                    metros = valor;

                if (cmbOrigen.Text == "Centímetros")
                    metros = valor / 100;

                if (cmbOrigen.Text == "Pulgadas")
                    metros = valor * 0.0254;


                double resultado = 0;

                // PASO 2: Convertir de metros a destino
                if (cmbDestino.Text == "Metros")
                    resultado = metros;

                if (cmbDestino.Text == "Centímetros")
                    resultado = metros * 100;

                if (cmbDestino.Text == "Pulgadas")
                    resultado = metros / 0.0254;


                lblResultado.Text = "Resultado: " + resultado.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido");
            }
        }
    }
    }
   

