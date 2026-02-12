using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double numero1 = 0;
            string operacion = "";
        }

        private void button7_Click(object sender, EventArgs e)
       
        {
            txtPantalla.Text += "6";
        }
       

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn5_Click(object sender, EventArgs e)
        
        {
            txtPantalla.Text += "5";
        }
       

        private void btn2_Click(object sender, EventArgs e)
       
        {
            txtPantalla.Text += "2";
        }
       

        private void btn0_Click(object sender, EventArgs e)
        
        {
            txtPantalla.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        
        {
            txtPantalla.Text += "1";
        }

        private void btn3_Click(object sender, EventArgs e)
        
        {
            txtPantalla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        
        {
            txtPantalla.Text += "4";
        }

        private void btn7_Click(object sender, EventArgs e)
    
        {
            txtPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
       
        {
            txtPantalla.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        
        {
            txtPantalla.Text += "9";
        }

       
            private void btnDividir_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txtPantalla.Text);
            operacion = "/";
            txtPantalla.Clear();
        }

        
            private void btnSuma_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txtPantalla.Text);
            operacion = "+";
            txtPantalla.Clear();
        }

       
            private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txtPantalla.Text);
            operacion = "*";
            txtPantalla.Clear();
        }

        
            private void btnResta_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(txtPantalla.Text);
            operacion = "-";
            txtPantalla.Clear();
        }

        
            private void btnIgual_Click(object sender, EventArgs e)
        {
            double numero2 = double.Parse(txtPantalla.Text);
            double resultado = 0;

            if (operacion == "+")
                resultado = numero1 + numero2;
            else if (operacion == "-")
                resultado = numero1 - numero2;
            else if (operacion == "*")
                resultado = numero1 * numero2;
            else if (operacion == "/")
                resultado = numero1 / numero2;

            txtPantalla.Text = resultado.ToString();
        }

       
            // Botón para borrar todo (C)
private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear(); // También puedes usar: txtPantalla.Text = "";
        }

        // Botón para eliminar el último dígito (DEL)
        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length > 0)
            {
                // Elimina el último carácter usando Remove
                txtPantalla.Text = txtPantalla.Text.Remove(txtPantalla.Text.Length - 1);
            }
        }

    }
}
    
    
    
    
   
    
    
   
   
   
    
   

