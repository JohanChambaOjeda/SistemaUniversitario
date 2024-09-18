using Sistema_Universitario.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sistema_Universitario.Models;


namespace Sistema_Universitario.Views
{
    public partial class FormMatriculas : Form
    {
        private MatriculaController matriculaController;
        private EstudianteController estudianteController;
        private CursoController cursoController;

        public FormMatriculas()
        {
            InitializeComponent();
            matriculaController = new MatriculaController();
            estudianteController = new EstudianteController();
            cursoController = new CursoController();

            CargarMatriculas();
            CargarEstudiantes();
            CargarCursos();
        }

        private void CargarMatriculas()
        {
            var matriculas = matriculaController.ObtenerMatriculas();
            dataGridViewMatriculas.DataSource = matriculas;
        }

        private void CargarEstudiantes()
        {
            var estudiantes = estudianteController.ObtenerEstudiantes();
            comboBoxEstudiantes.DataSource = estudiantes;
            comboBoxEstudiantes.DisplayMember = "Nombre";
            comboBoxEstudiantes.ValueMember = "ID_Estudiante";
        }

        private void CargarCursos()
        {
            var cursos = cursoController.ObtenerCursos();
            comboBoxCursos.DataSource = cursos;
            comboBoxCursos.DisplayMember = "Nombre";
            comboBoxCursos.ValueMember = "ID_Curso";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idEstudiante = (int)comboBoxEstudiantes.SelectedValue;
            int idCurso = (int)comboBoxCursos.SelectedValue;
            matriculaController.AgregarMatricula(idEstudiante, idCurso);
            CargarMatriculas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMatriculas.SelectedRows.Count > 0)
            {
                int idMatricula = Convert.ToInt32(dataGridViewMatriculas.SelectedRows[0].Cells[0].Value);
                matriculaController.EliminarMatricula(idMatricula);
                CargarMatriculas();
            }
            else
            {
                MessageBox.Show("Seleccione una matricula para eliminar.");
            }
        }
    }
}