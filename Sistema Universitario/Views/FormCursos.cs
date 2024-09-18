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

namespace Sistema_Universitario.Views
{
    public partial class FormCursos : Form
    {
        private CursoController cursoController;

        public FormCursos()
        {
            InitializeComponent();
            cursoController = new CursoController();
            CargarCursos();
        }

        private void CargarCursos()
        {
            var cursos = cursoController.ObtenerCursos();
            dataGridViewCursos.DataSource = cursos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                cursoController.AgregarCurso(nombre);
                CargarCursos();
                textBoxNombre.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre para el curso.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCursos.SelectedRows.Count > 0)
            {
                int idCurso = Convert.ToInt32(dataGridViewCursos.SelectedRows[0].Cells[0].Value);
                cursoController.EliminarCurso(idCurso);
                CargarCursos();
            }
            else
            {
                MessageBox.Show("Seleccione un curso para eliminar.");
            }
        }
    }
}