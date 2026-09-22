using System.Data.SqlClient;

namespace CapaDatos
{
    public class DConexion
    {
        private readonly string cadenaConexion =
            @"Server=.\SQLEXPRESS;Database=BD_TEST;Integrated Security=True;";

        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}