
namespace ProyectoEjerciciosCap6Y7
{
    partial class Ejercicio2Cap6
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
            this.textBoxCaliMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listPromedio = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.textBoxSalones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCaliMin
            // 
            this.textBoxCaliMin.Location = new System.Drawing.Point(178, 495);
            this.textBoxCaliMin.Name = "textBoxCaliMin";
            this.textBoxCaliMin.Size = new System.Drawing.Size(70, 27);
            this.textBoxCaliMin.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Calificiacion Minima:";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(227, 560);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(101, 45);
            this.Salir.TabIndex = 16;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(67, 560);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(97, 45);
            this.Nuevo.TabIndex = 15;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listPromedio);
            this.groupBox2.Location = new System.Drawing.Point(25, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 198);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado Promedio";
            // 
            // listPromedio
            // 
            this.listPromedio.FormattingEnabled = true;
            this.listPromedio.ItemHeight = 20;
            this.listPromedio.Location = new System.Drawing.Point(6, 49);
            this.listPromedio.Name = "listPromedio";
            this.listPromedio.Size = new System.Drawing.Size(364, 124);
            this.listPromedio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 84);
            this.label2.TabIndex = 13;
            this.label2.Text = "En este programa pediremos el numero de salones \r\ny sus respectivos alumnos y sus" +
    " calificaciones, \r\nluego calcularemos el promedio usando un \r\narreglo tipo jagge" +
    "d, y calcula la calificacion minima:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Aceptar);
            this.groupBox1.Controls.Add(this.textBoxSalones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 144);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Salones";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(116, 93);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(94, 29);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // textBoxSalones
            // 
            this.textBoxSalones.Location = new System.Drawing.Point(175, 44);
            this.textBoxSalones.Name = "textBoxSalones";
            this.textBoxSalones.Size = new System.Drawing.Size(136, 27);
            this.textBoxSalones.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Salones:";
            // 
            // Ejercicio2Cap6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 639);
            this.Controls.Add(this.textBoxCaliMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ejercicio2Cap6";
            this.Text = "Ejercicio3Cap6";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCaliMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listPromedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.TextBox textBoxSalones;
        private System.Windows.Forms.Label label1;
    }
}