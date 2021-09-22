using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEjerciciosCap6Y7
{
    public partial class Contactos : Form
    {
        public string Nombre;
        public string Telefono;
        public string Ciudad;
        public Contactos()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            if(ciudad.ShowDialog() == DialogResult.OK)
            {
                comboBoxCiudad.Items.Add(ciudad.Nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nombre = textBoxNombre.Text;
            Telefono = maskedTextBoxTelefono.Text;
            Ciudad = comboBoxCiudad.Text;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
