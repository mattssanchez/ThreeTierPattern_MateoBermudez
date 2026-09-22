using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NUsuario
    {
        private readonly DUsuario datos = new DUsuario();

        public DataTable SeleccionarTodos()
        {
            return datos.SeleccionarTodos();
        }

        public DataTable Seleccionar(int id)
        {
            return datos.Seleccionar(id);
        }

        public void Insertar(
            string usuario,
            string contrasena,
            int intentos,
            decimal nivelSeg,
            DateTime fechaReg)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new Exception(
                    "El usuario es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                throw new Exception(
                    "La contraseña es obligatoria.");
            }

            if (intentos < 0)
            {
                throw new Exception(
                    "Los intentos no pueden ser negativos.");
            }

            if (nivelSeg < 0)
            {
                throw new Exception(
                    "El nivel de seguridad no puede ser negativo.");
            }

            datos.Insertar(
                usuario,
                contrasena,
                intentos,
                nivelSeg,
                fechaReg);
        }

        public void Actualizar(
            int id,
            string usuario,
            string contrasena,
            int intentos,
            decimal nivelSeg,
            DateTime fechaReg)
        {
            if (id <= 0)
            {
                throw new Exception(
                    "Seleccione un usuario válido.");
            }

            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new Exception(
                    "El usuario es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                throw new Exception(
                    "La contraseña es obligatoria.");
            }

            if (intentos < 0)
            {
                throw new Exception(
                    "Los intentos no pueden ser negativos.");
            }

            if (nivelSeg < 0)
            {
                throw new Exception(
                    "El nivel de seguridad no puede ser negativo.");
            }

            datos.Actualizar(
                id,
                usuario,
                contrasena,
                intentos,
                nivelSeg,
                fechaReg);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
            {
                throw new Exception(
                    "Seleccione un usuario válido.");
            }

            datos.Eliminar(id);
        }
    }
}
