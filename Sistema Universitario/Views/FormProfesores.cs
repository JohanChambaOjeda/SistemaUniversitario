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
    public partial class FormProfesores : Form
    {
        private ProfesorController profesorController;

        public FormProfesores()
        {
            InitializeComponent();
            profesorController = new ProfesorController();
            CargarProfesores();
        }

        private void CargarProfesores()
        {
            var profesores = profesorController.ObtenerProfesores();
            dataGridViewProfesores.DataSource = profesores;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                profesorController.AgregarProfesor(nombre);
                CargarProfesores();
                textBoxNombre.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfesores.SelectedRows.Count > 0)
            {
                int idProfesor = Convert.ToInt32(dataGridViewProfesores.SelectedRows[0].Cells[0].Value);
                profesorController.EliminarProfesor(idProfesor);
                CargarProfesores();
            }
            else
            {
                MessageBox.Show("Seleccione un profesor para eliminar.");
            }
        }
    }
}
