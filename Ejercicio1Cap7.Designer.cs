
namespace ProyectoEjerciciosCap6Y7
{
    partial class Ejercicio1Cap7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupDatAlumno = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAlumnos = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPromedio = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.groupDatAlumno.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDatAlumno
            // 
            this.groupDatAlumno.Controls.Add(this.Aceptar);
            this.groupDatAlumno.Controls.Add(this.textBoxAlumnos);
            this.groupDatAlumno.Controls.Add(this.label1);
            this.groupDatAlumno.Location = new System.Drawing.Point(32, 119);
            this.groupDatAlumno.Name = "groupDatAlumno";
            this.groupDatAlumno.Size = new System.Drawing.Size(352, 148);
            this.groupDatAlumno.TabIndex = 0;
            this.groupDatAlumno.TabStop = false;
            this.groupDatAlumno.Text = "Datos de Alumnos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de estudiantes:";
            // 
            // textBoxAlumnos
            // 
            this.textBoxAlumnos.Location = new System.Drawing.Point(190, 50);
            this.textBoxAlumnos.Name = "textBoxAlumnos";
            this.textBoxAlumnos.Size = new System.Drawing.Size(125, 27);
            this.textBoxAlumnos.TabIndex = 1;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(122, 97);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(94, 29);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMin);
            this.groupBox1.Controls.Add(this.textBoxMax);
            this.groupBox1.Controls.Add(this.textBoxPromedio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Salon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Promedio del Salon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Calificacion Maxima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Calificacion Minima:";
            // 
            // textBoxPromedio
            // 
            this.textBoxPromedio.Location = new System.Drawing.Point(176, 38);
            this.textBoxPromedio.Name = "textBoxPromedio";
            this.textBoxPromedio.Size = new System.Drawing.Size(96, 27);
            this.textBoxPromedio.TabIndex = 3;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(176, 82);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(96, 27);
            this.textBoxMax.TabIndex = 4;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(176, 126);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(96, 27);
            this.textBoxMin.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 66);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hacer el programa que calcula el promedio,\r\ncalificación máxima y mínima de un sa" +
    "lón de \r\nclases usando el ArrayList:";
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(73, 507);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(94, 29);
            this.Nuevo.TabIndex = 3;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(254, 507);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(94, 29);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Ejercicio1Cap7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 566);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupDatAlumno);
            this.Name = "Ejercicio1Cap7";
            this.Text = "Ejercicio1Cap7";
            this.groupDatAlumno.ResumeLayout(false);
            this.groupDatAlumno.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDatAlumno;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.TextBox textBoxAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxPromedio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Salir;
    }
}