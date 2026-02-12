using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarFecha_Click(object sender, EventArgs e)
       
        {
            try
            {
                // Extraemos la fecha del control dtpFecha
                // Usamos .ToString("dd/MM/yyyy") para forzar el formato exacto
                string fechaFormateada = dtpFecha.Value.ToString("dd/MM/yyyy");

                // Actualizamos la etiqueta (Label)
                lblResultadoFecha.Text = "Fecha seleccionada: " + fechaFormateada;

                // Cambiamos el color para confirmar que funcionó
                lblResultadoFecha.ForeColor = System.Drawing.Color.DarkGreen;
            }
            catch (Exception ex)
            {
                // Si algo sale mal, Visual Studio nos avisará aquí
                MessageBox.Show("Error al leer la fecha: " + ex.Message);
            }
        }

    }
}

