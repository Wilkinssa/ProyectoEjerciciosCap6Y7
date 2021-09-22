
namespace ProyectoEjerciciosCap6Y7
{
    partial class Ejercicio1Cap6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.textBoxSalones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.listPromedio = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Aceptar);
            this.groupBox1.Controls.Add(this.textBoxSalones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 144);
            this.groupBox1.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = "En este programa pediremos el numero de salones \r\ny sus respectivos alumnos y sus" +
    " calificaciones, \r\nluego calcularemos el promedio usando un \r\narreglo tipo jagge" +
    "d:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listPromedio);
            this.groupBox2.Location = new System.Drawing.Point(26, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 198);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Estudiantes";
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(69, 516);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(97, 45);
            this.Nuevo.TabIndex = 3;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(229, 516);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(101, 45);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // listPromedio
            // 
            this.listPromedio.FormattingEnabled = true;
            this.listPromedio.ItemHeight = 20;
            this.listPromedio.Location = new System.Drawing.Point(6, 68);
            this.listPromedio.Name = "listPromedio";
            this.listPromedio.Size = new System.Drawing.Size(364, 124);
            this.listPromedio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Promedios:";
            // 
            // Ejercicio1Cap6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 601);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ejercicio1Cap6";
            this.Text = "Ejercicio1Cap6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.TextBox textBoxSalones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.ListBox listPromedio;
        private System.Windows.Forms.Label label4;
    }
}