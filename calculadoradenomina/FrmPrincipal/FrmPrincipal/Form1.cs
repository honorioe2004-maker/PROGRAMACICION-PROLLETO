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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registroPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        
        {
            FrmPersona frm = new FrmPersona();
            frm.MdiParent = this;
            frm.Show();
        }

        private void conversorDivisasToolStripMenuItem_Click(object sender, EventArgs e)
       
        {
            FrmDivisas frm = new FrmDivisas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void serieFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
      
        {
            FrmFibonacci frm = new FrmFibonacci();
            frm.MdiParent = this;
            frm.Show();
        }
    }
    }
   
    

