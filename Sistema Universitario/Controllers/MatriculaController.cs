using Sistema_Universitario.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Universitario.Controllers
{
    public class MatriculaController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SistemaUniversitarioDB"].ConnectionString;

        public List<MatriculaModels> ObtenerMatriculas()
        {
            List<MatriculaModels> matriculas = new List<MatriculaModels>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Matriculas", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        matriculas.Add(new MatriculaModels
                        {
                            ID_Matricula = reader.GetInt32(0),
                            ID_Estudiante = reader.GetInt32(1),
                            ID_Curso = reader.GetInt32(2)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                throw new Exception("Error al obtener las matriculas: " + ex.Message);
            }

            return matriculas;
        }

        public void AgregarMatricula(int idEstudiante, int idCurso)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Matriculas (ID_Estudiante, ID_Curso) VALUES (@ID_Estudiante, @ID_Curso)", conn);
                    cmd.Parameters.AddWithValue("@ID_Estudiante", idEstudiante);
                    cmd.Parameters.AddWithValue("@ID_Curso", idCurso);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                throw new Exception("Error al agregar la matricula: " + ex.Message);
            }
        }

        public void EliminarMatricula(int idMatricula)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Matriculas WHERE ID_Matricula = @ID_Matricula", conn);
                    cmd.Parameters.AddWithValue("@ID_Matricula", idMatricula);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                throw new Exception("Error al eliminar la matricula: " + ex.Message);
            }
        }
    }
}