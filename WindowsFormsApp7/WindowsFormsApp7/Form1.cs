using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
            private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbOpcion1.Checked)
                lblOpcion.Text = rbOpcion1.Text;
            else if (rbOpcion2.Checked)
                lblOpcion.Text = rbOpcion2.Text;
            else if (rbOpcion3.Checked)
                lblOpcion.Text = rbOpcion3.Text;
        }
    }
    }

