using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private readonly NUsuario negocio =
            new NUsuario();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(
            object sender,
            EventArgs e)
        {
            CargarUsuarios();

            LimpiarCampos();
        }

        private void CargarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource =
                    negocio.SeleccionarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnInsertar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                int intentos =
                    Convert.ToInt32(txtIntentos.Text);

                decimal nivelSeg =
                    Convert.ToDecimal(txtNivelSeg.Text);

                negocio.Insertar(
                    txtUsuario.Text,
                    txtContrasena.Text,
                    intentos,
                    nivelSeg,
                    dtpFechaReg.Value);

                MessageBox.Show(
                    "Usuario insertado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarUsuarios();

                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Intentos y Nivel de Seguridad deben ser valores numéricos.",
                    "Datos inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                int id =
                    Convert.ToInt32(txtId.Text);

                int intentos =
                    Convert.ToInt32(txtIntentos.Text);

                decimal nivelSeg =
                    Convert.ToDecimal(txtNivelSeg.Text);

                negocio.Actualizar(
                    id,
                    txtUsuario.Text,
                    txtContrasena.Text,
                    intentos,
                    nivelSeg,
                    dtpFechaReg.Value);

                MessageBox.Show(
                    "Usuario actualizado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarUsuarios();

                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Verifique los valores numéricos.",
                    "Datos inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                int id =
                    Convert.ToInt32(txtId.Text);

                DialogResult resultado =
                    MessageBox.Show(
                        "¿Está seguro de eliminar este usuario?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    negocio.Eliminar(id);

                    MessageBox.Show(
                        "Usuario eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarUsuarios();

                    LimpiarCampos();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Seleccione un usuario de la tabla.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();

            txtIntentos.Text = "0";
            txtNivelSeg.Text = "0";

            dtpFechaReg.Value = DateTime.Now;

            txtUsuario.Focus();
        }

        private void dgvUsuarios_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvUsuarios.Rows[e.RowIndex];

            txtId.Text =
                fila.Cells["id"].Value?.ToString();

            txtUsuario.Text =
                fila.Cells["usuario"].Value?.ToString();

            txtContrasena.Text =
                fila.Cells["contrasena"].Value?.ToString();

            txtIntentos.Text =
                fila.Cells["intentos"].Value?.ToString();

            txtNivelSeg.Text =
                fila.Cells["nivelSeg"].Value?.ToString();

            if (fila.Cells["fechaReg"].Value != DBNull.Value &&
                fila.Cells["fechaReg"].Value != null)
            {
                dtpFechaReg.Value =
                    Convert.ToDateTime(
                        fila.Cells["fechaReg"].Value);
            }
        }
    }
}