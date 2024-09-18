using Sistema_Universitario.Controllers;
using Sistema_Universitario.Models;
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
    public partial class FormEstudiantes : Form
    {
        private EstudianteController estudianteController;

        public FormEstudiantes()
        {
            InitializeComponent();
            estudianteController = new EstudianteController();
            CargarEstudiantes();
        }

        private void CargarEstudiantes()
        {
            var estudiantes = estudianteController.ObtenerEstudiantes();
            dataGridViewEstudiantes.DataSource = estudiantes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                estudianteController.AgregarEstudiante(nombre);
                CargarEstudiantes();
                textBoxNombre.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEstudiantes.SelectedRows.Count > 0)
            {
                int idEstudiante = Convert.ToInt32(dataGridViewEstudiantes.SelectedRows[0].Cells[0].Value);
                estudianteController.EliminarEstudiante(idEstudiante);
                CargarEstudiantes();
            }
            else
            {
                MessageBox.Show("Seleccione un estudiante para eliminar.");
            }
        }
    }
}