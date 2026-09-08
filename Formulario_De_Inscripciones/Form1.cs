using Formulario_De_Inscripciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_De_Inscripciones
{
    public partial class Form1 : Form
    {
        List<string> alumnos = new List<string>();
        List<string> cursos = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar DataGridView
            dgvInscripciones.ColumnCount = 2;
            dgvInscripciones.Columns[0].Name = "Alumno";
            dgvInscripciones.Columns[1].Name = "Curso";

            dgvInscripciones.AllowUserToAddRows = false;
            dgvInscripciones.ReadOnly = true;
            dgvInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscripciones.MultiSelect = false;

            cmbAlumnos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCursos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // AGREGAR ALUMNO
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            string alumno = txtAlumno.Text.Trim();

            if (alumno == "")
            {
                MessageBox.Show("Ingrese el nombre del alumno.");
                return;
            }

            if (alumnos.Contains(alumno))
            {
                MessageBox.Show("Ese alumno ya está registrado.");
                return;
            }

            alumnos.Add(alumno);
            cmbAlumnos.Items.Add(alumno);

            MessageBox.Show("Alumno agregado correctamente.");

            txtAlumno.Clear();
            txtAlumno.Focus();
        }

        // AGREGAR CURSO
        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            string curso = cmbCursos.Text.Trim();

            if (curso == "")
            {
                MessageBox.Show("Ingrese un curso.");
                return;
            }

            if (cursos.Contains(curso))
            {
                MessageBox.Show("Ese curso ya existe.");
                return;
            }

            cursos.Add(curso);
            cmbCursos.Items.Add(curso);

            MessageBox.Show("Curso agregado correctamente.");

          
           cmbCursos.Focus();
        }

        // INSCRIBIR
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (cmbAlumnos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un alumno.");
                return;
            }

            if (cmbCursos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso.");
                return;
            }

            string alumno = cmbAlumnos.SelectedItem.ToString();
            string curso = cmbCursos.SelectedItem.ToString();

            // Evitar duplicados
            foreach (DataGridViewRow fila in dgvInscripciones.Rows)
            {
                if (fila.Cells[0].Value?.ToString() == alumno &&
                    fila.Cells[1].Value?.ToString() == curso)
                {
                    MessageBox.Show("El alumno ya está inscripto en ese curso.");
                    return;
                }
            }

            dgvInscripciones.Rows.Add(alumno, curso);

            MessageBox.Show("Inscripción realizada correctamente.");

            cmbAlumnos.SelectedIndex = -1;
            cmbCursos.SelectedIndex = -1;
        }

        // ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInscripciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una inscripción.");
                return;
            }

            dgvInscripciones.Rows.RemoveAt(dgvInscripciones.SelectedRows[0].Index);

            MessageBox.Show("Inscripción eliminada.");
        }
    }
}