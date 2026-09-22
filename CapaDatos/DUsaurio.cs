using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DUsuario : DConexion
    {
        public DataTable SeleccionarTodos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand("SP_SELECCIONAR_ALL_USUARIO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(comando);

                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }

        public DataTable Seleccionar(int id)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand("SP_SELECCIONAR_USUARIO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id", id);

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(comando);

                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }

        public void Insertar(
            string usuario,
            string contrasena,
            int intentos,
            decimal nivelSeg,
            DateTime fechaReg)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand comando =
                    new SqlCommand("SP_INSERTAR_USUARIO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@usuario", usuario);

                    comando.Parameters.AddWithValue(
                        "@contrasena", contrasena);

                    comando.Parameters.AddWithValue(
                        "@intentos", intentos);

                    comando.Parameters.AddWithValue(
                        "@nivelSeg", nivelSeg);

                    comando.Parameters.AddWithValue(
                        "@fechaReg", fechaReg.Date);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(
            int id,
            string usuario,
            string contrasena,
            int intentos,
            decimal nivelSeg,
            DateTime fechaReg)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand comando =
                    new SqlCommand("SP_ACTUALIZAR_USUARIO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue(
                        "@usuario", usuario);

                    comando.Parameters.AddWithValue(
                        "@contrasena", contrasena);

                    comando.Parameters.AddWithValue(
                        "@intentos", intentos);

                    comando.Parameters.AddWithValue(
                        "@nivelSeg", nivelSeg);

                    comando.Parameters.AddWithValue(
                        "@fechaReg", fechaReg.Date);

                    comando.Parameters.AddWithValue(
                        "@id", id);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (SqlCommand comando =
                    new SqlCommand("SP_ELIMINAR_USUARIO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}