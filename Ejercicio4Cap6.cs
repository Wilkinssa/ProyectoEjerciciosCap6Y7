using System;
using System.Collections.Generic;
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
    public partial class Ejercicio4Cap6 : Form
    {
        public Ejercicio4Cap6()
        {
            InitializeComponent();
        }
        public void EscribirMaxMin(float max, float min)
        {
            textBoxCalifMax.Text = Convert.ToString(max);
            textBoxCaliMin.Text = Convert.ToString(min);
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            int salones = 0;

            float suma = 0.0f;
            float Menor = 999f;
            float Mayor = 0f;

            salones = Convert.ToInt32(textBoxSalones.Text);

            float[][] calif = new float[salones][];
            float[] promedio = new float[salones];

            for (int i = 0; i < salones; i++)
            {
                cantidad = Convert.ToInt32(Interaction.InputBox("Ingrese el numero de alumnos para el salon " + (i + 1), " Cantidad de Alumnos"));

                calif[i] = new float[cantidad];
            }

            for (int i = 0; i < salones; i++)
            {

                for (int j = 0; j < calif[i].GetLength(0); j++)
                {
                    calif[i][j] = Convert.ToSingle(Interaction.InputBox("Ingrese la calificacion del alumno " + (j + 1) + " del salon " + (i + 1), "Calificacion de Alumno"));

                    suma += calif[i][j];

                    if (calif[i][j] < Menor)
                        Menor = calif[i][j];
                    if (calif[i][j] > Mayor)
                        Mayor = calif[i][j];
                }
                promedio[i] = suma / calif[i].GetLength(0);
                suma = 0;
            }


            for (int i = 0; i < salones; i++)
            {
                listPromedio.Items.Add("Promedio del salon " + (i + 1) + ": " + Math.Round(promedio[i], 2, MidpointRounding.ToEven).ToString() + ".");

            }
            EscribirMaxMin(Mayor, Menor);
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            textBoxCalifMax.Clear();
            textBoxCaliMin.Clear();
            listPromedio.Items.Clear();
            textBoxSalones.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
