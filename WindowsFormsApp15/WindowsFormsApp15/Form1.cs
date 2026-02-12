using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTab1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        
        {
            // Identificamos cuál pestaña está seleccionada por su índice (0, 1, 2...)
            if (pestañasPrincipal.SelectedIndex == 0)
            {
                lblTab1.Text = "Estás viendo el Perfil";
            }
            else if (pestañasPrincipal.SelectedIndex == 1)
            {
                lblTab2.Text = "Estás viendo el Contacto";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

