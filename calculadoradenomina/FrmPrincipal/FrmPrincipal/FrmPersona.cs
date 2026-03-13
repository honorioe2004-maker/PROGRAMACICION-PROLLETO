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
    public partial class FrmPersona : Form
    {
        public FrmPersona()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        
        {
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido", "Apellido");
            dataGridView1.Columns.Add("Edad", "Edad");
            dataGridView1.Columns.Add("Cedula", "Cedula");
            dataGridView1.Columns.Add("Telefono", "Telefono");
            dataGridView1.Columns.Add("Correo", "Correo");
            dataGridView1.Columns.Add("Direccion", "Direccion");
            dataGridView1.Columns.Add("Ciudad", "Ciudad");
            dataGridView1.Columns.Add("Pais", "Pais");
            dataGridView1.Columns.Add("Sexo", "Sexo");
            dataGridView1.Columns.Add("EstadoCivil", "Estado Civil");
            dataGridView1.Columns.Add("Profesion", "Profesion");
        }
        

        private void button1_Click(object sender, EventArgs e)
        
        {
            dataGridView1.Rows.Add(
                txtNombre.Text,
                txtApellido.Text,
                txtEdad.Text,
                txtCedula.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                txtDireccion.Text,
                txtCiudad.Text,
                txtPais.Text,
                txtSexo.Text,
                txtEstadoCivil.Text,
                txtProfesion.Text
            );
        }
    }
    }

