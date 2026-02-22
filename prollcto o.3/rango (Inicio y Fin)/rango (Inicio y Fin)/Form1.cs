using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rango__Inicio_y_Fin_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
            private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstPrimos.Items.Clear();

            if (int.TryParse(txtInicio.Text, out int inicio) &&
                int.TryParse(txtFin.Text, out int fin))
            {
                for (int n = inicio; n <= fin; n++)
                {
                    bool esPrimo = true;

                    if (n <= 1)
                        esPrimo = false;

                    for (int i = 2; i <= Math.Sqrt(n); i++)
                    {
                        if (n % i == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }

                    if (esPrimo)
                        lstPrimos.Items.Add(n);
                }
            }
        }
    }
    }

