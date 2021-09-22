using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProyectoEjerciciosCap6Y7
{
    public partial class Ejercicio1Cap7 : Form
    {
        public Ejercicio1Cap7()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            int Nalumnos = Convert.ToInt32(textBoxAlumnos.Text);
            float suma = 0;
            float promedio = 0;
            float Max = 0;
            float Min = 999f;

            ArrayList Calif = new ArrayList();

            for(int i = 0; i < Nalumnos; i++)
            {
                Calif.Add(Convert.ToSingle(Interaction.InputBox("Ingrese la Calificacion del alumno " + (i + 1) + ":", "Calificaciones")));
                
                if(Convert.ToSingle(Calif[i]) > Max)
                    Max = Convert.ToSingle(Calif[i]);

                if (Convert.ToSingle(Calif[i]) < Min)
                    Min = Convert.ToSingle(Calif[i]);

                suma += Convert.ToSingle(Calif[i]);
            }
            promedio = suma / Nalumnos;

            textBoxPromedio.Text = Convert.ToString(promedio);
            textBoxMax.Text = Convert.ToString(Max);
            textBoxMin.Text = Convert.ToString(Min);
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            textBoxAlumnos.Clear();
            textBoxPromedio.Clear();
            textBoxMax.Clear();
            textBoxMin.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
