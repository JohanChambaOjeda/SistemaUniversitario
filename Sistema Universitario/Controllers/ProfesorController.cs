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
    public class ProfesorController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SistemaUniversitarioDB"].ConnectionString;

        public List<ProfesorModels> ObtenerProfesores()
        {
            List<ProfesorModels> profesores = new List<ProfesorModels>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Profesores", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        profesores.Add(new ProfesorModels
                        {
                            ID_Profesor = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                throw new Exception("Error al obtener los profesores: " + ex.Message);
            }

            return profesores;
        }

        public void AgregarProfesor(string nombre)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Profesores (Nombre) VALUES (@Nombre)", conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                throw new Exception("Error al agregar el profesor: " + ex.Message);
            }
        }

        public void EliminarProfesor(int idProfesor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Profesores WHERE ID_Profesor = @ID_Profesor", conn);
                    cmd.Parameters.AddWithValue("@ID_Profesor", idProfesor);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar el error
                throw new Exception("Error al eliminar el profesor: " + ex.Message);
            }
        }
    }
}