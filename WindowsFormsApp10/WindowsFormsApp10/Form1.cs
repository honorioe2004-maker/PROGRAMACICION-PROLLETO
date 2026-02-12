using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbColores_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (cmbColores.Text == "Rojo")
            {
                this.BackColor = Color.Red;
            }
            else if (cmbColores.Text == "Verde")
            {
                this.BackColor = Color.Green;
            }
            else if (cmbColores.Text == "Azul")
            {
                this.BackColor = Color.Blue;
            }
        }
    }
    }

