using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temporizador
{
    public partial class Form1 : Form
    {
        int tiempoRestante;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
            private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMinutos.Text, out int min) &&
                int.TryParse(txtSegundos.Text, out int seg))
            {
                tiempoRestante = (min * 60) + seg;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos");
            }
        }

        
            private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--;
                lblTiempo.Text = tiempoRestante.ToString() + " segundos";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Tiempo agotado");
            }
        }
    }
    }
    

