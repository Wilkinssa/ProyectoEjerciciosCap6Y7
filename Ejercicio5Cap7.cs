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
    public partial class Ejercicio5Cap7 : Form
    {
        List<ClsContacto> ContactosList = new List<ClsContacto>();
        public Ejercicio5Cap7()
        {
            InitializeComponent();
        }
        ClsContacto Contact = new ClsContacto();
        private void LlenarDataGrid()
        {
            dataGridContacto.DataSource = null;
            if(ContactosList.Count > 0)
            {
                dataGridContacto.DataSource = ContactosList;
            }
        }
        private void Ejercicio5Cap7_Load(object sender, EventArgs e)
        {
            //Cargar el listado de Contactos
            LlenarDataGrid();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Contactos Nuevo = new Contactos();
            if(Nuevo.ShowDialog() == DialogResult.OK)
            {
                //Cargar nuevamente el listado
                Contact = new ClsContacto();
                Contact.Nombre = Nuevo.Nombre;
                Contact.Telefono = Nuevo.Telefono;
                Contact.Ciudad = Nuevo.Ciudad;
                ContactosList.Add(Contact);
                LlenarDataGrid();
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            ContactosList.RemoveAt(dataGridContacto.CurrentRow.Index);
            LlenarDataGrid();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
