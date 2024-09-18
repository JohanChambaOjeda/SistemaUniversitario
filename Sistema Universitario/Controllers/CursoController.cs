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
    public class CursoController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SistemaUniversitarioDB"].ConnectionString;

        public List<CursoModels> ObtenerCursos()
        {
            List<CursoModels> cursos = new List<CursoModels>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Cursos", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cursos.Add(new CursoModels
                        {
                            ID_Curso = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                throw new Exception("Error al obtener los cursos: " + ex.Message);
            }

            return cursos;
        }

        public void AgregarCurso(string nombre)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Cursos (Nombre) VALUES (@Nombre)", conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                throw new Exception("Error al agregar el curso: " + ex.Message);
            }
        }

        public void EliminarCurso(int idCurso)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Cursos WHERE ID_Curso = @ID_Curso", conn);
                    cmd.Parameters.AddWithValue("@ID_Curso", idCurso);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                throw new Exception("Error al eliminar el curso: " + ex.Message);
            }
        }
    }
}