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
    public partial class FrmDivisas : Form
    {
        public FrmDivisas()
        {
            InitializeComponent();
        }

        private void FrmDivisas_Load(object sender, EventArgs e)
        
        {
            cmbDe.Items.Add("USD");
            cmbDe.Items.Add("DOP");
            cmbDe.Items.Add("EUR");

            cmbA.Items.Add("USD");
            cmbA.Items.Add("DOP");
            cmbA.Items.Add("EUR");
        }

        private void button1_Click(object sender, EventArgs e)
      
        {
            double cantidad = Convert.ToDouble(txtCantidad.Text);
            double resultado = 0;

            if (cmbDe.Text == "USD" && cmbA.Text == "DOP")
                resultado = cantidad * 59;

            else if (cmbDe.Text == "DOP" && cmbA.Text == "USD")
                resultado = cantidad / 59;

            else if (cmbDe.Text == "USD" && cmbA.Text == "EUR")
                resultado = cantidad * 0.92;

            else if (cmbDe.Text == "EUR" && cmbA.Text == "USD")
                resultado = cantidad / 0.92;

            else
                resultado = cantidad;

            lblResultado.Text = resultado.ToString();
        }
    }
    }
   

