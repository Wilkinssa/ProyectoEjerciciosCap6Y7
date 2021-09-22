
namespace ProyectoEjerciciosCap6Y7
{
    partial class Ejercicio5Cap7
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridContacto = new System.Windows.Forms.DataGridView();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hacer un programa que funcione como una agenda telefónica y que guarde el\r\nnombre" +
    " de la persona y su número telefónico:";
            // 
            // dataGridContacto
            // 
            this.dataGridContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridContacto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContacto.Location = new System.Drawing.Point(12, 60);
            this.dataGridContacto.Name = "dataGridContacto";
            this.dataGridContacto.RowHeadersWidth = 51;
            this.dataGridContacto.RowTemplate.Height = 29;
            this.dataGridContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridContacto.Size = new System.Drawing.Size(653, 430);
            this.dataGridContacto.TabIndex = 1;
            // 
            // Nuevo
            // 
            this.Nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Nuevo.Location = new System.Drawing.Point(14, 496);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(74, 30);
            this.Nuevo.TabIndex = 2;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Eliminar.Location = new System.Drawing.Point(106, 496);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(74, 30);
            this.Eliminar.TabIndex = 3;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Location = new System.Drawing.Point(573, 496);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(74, 30);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Ejercicio5Cap7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 536);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.dataGridContacto);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio5Cap7";
            this.Text = "Ejercicio5Cap7";
            this.Load += new System.EventHandler(this.Ejercicio5Cap7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridContacto;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Salir;
    }
}