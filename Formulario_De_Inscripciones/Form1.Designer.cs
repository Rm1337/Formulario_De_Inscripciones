using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Formulario_De_Inscripciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnAgregarCurso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(84, 20);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno.TabIndex = 1;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(189, 18);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(105, 23);
            this.btnAgregarAlumno.TabIndex = 2;
            this.btnAgregarAlumno.Text = "Agregar Alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.Location = new System.Drawing.Point(231, 84);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCurso.TabIndex = 5;
            this.btnAgregarCurso.Text = "Agregar Curso";
            this.btnAgregarCurso.UseVisualStyleBackColor = true;
            this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccionar Curso";
            // 
            // cmbCursos
            // 
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Items.AddRange(new object[] {
            "Tejido",
            "Crochet",
            "Macrame"});
            this.cmbCursos.Location = new System.Drawing.Point(104, 86);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(121, 21);
            this.cmbCursos.TabIndex = 7;
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(312, 86);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(73, 23);
            this.btnInscribir.TabIndex = 8;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(391, 86);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvInscripciones
            // 
            this.dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripciones.Location = new System.Drawing.Point(55, 147);
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.Size = new System.Drawing.Size(240, 150);
            this.dgvInscripciones.TabIndex = 11;
            this.dgvInscripciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvInscripciones.Leave += new System.EventHandler(this.Form1_Load);
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(118, 52);
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(121, 21);
            this.cmbAlumnos.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seleccionar alumno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "INSCRIPCIONES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbAlumnos);
            this.Controls.Add(this.dgvInscripciones);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.cmbCursos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarCurso);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnAgregarCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnEliminar;
        private DataGridView dgvInscripciones;
        private ComboBox cmbAlumnos;
        private Label label4;
        private Label label5;
    }
}

