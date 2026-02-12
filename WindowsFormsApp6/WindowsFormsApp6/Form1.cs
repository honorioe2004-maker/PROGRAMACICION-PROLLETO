using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNumero1.Text);
            int n2 = int.Parse(txtNumero2.Text);
            lblSuma.Text = (n1 + n2).ToString();                                                     
        }
    }
}
