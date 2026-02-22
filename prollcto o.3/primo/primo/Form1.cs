using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
            private void btnPrimo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(mtxtNumero.Text, out int numero))
            {
                bool esPrimo = true;

                if (numero <= 1)
                    esPrimo = false;

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                    MessageBox.Show("Es primo");
                else
                    MessageBox.Show("No es primo");
            }
        }
    }
    }

