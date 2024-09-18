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
    public class EstudianteController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SistemaUniversitarioDB"].ConnectionString;

        public List<EstudianteModels> ObtenerEstudiantes()
        {
            List<EstudianteModels> estudiantes = new List<EstudianteModels>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Estudiantes", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        estudiantes.Add(new EstudianteModels
                        {
                            ID_Estudiante = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                throw new Exception("Error al obtener los estudiantes: " + ex.Message);
            }

            return estudiantes;
        }

        public void AgregarEstudiante(string nombre)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Estudiantes (Nombre) VALUES (@Nombre)", conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                throw new Exception("Error al agregar el estudiante: " + ex.Message);
            }
        }

        public void EliminarEstudiante(int idEstudiante)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Estudiantes WHERE ID_Estudiante = @ID_Estudiante", conn);
                    cmd.Parameters.AddWithValue("@ID_Estudiante", idEstudiante);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                throw new Exception("Error al eliminar el estudiante: " + ex.Message);
            }
        }
    }
}