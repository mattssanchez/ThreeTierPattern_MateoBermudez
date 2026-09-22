namespace CapaPresentacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Label lblNivelSeg;
        private System.Windows.Forms.Label lblFechaReg;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtIntentos;
        private System.Windows.Forms.TextBox txtNivelSeg;

        private System.Windows.Forms.DateTimePicker dtpFechaReg;

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.DataGridView dgvUsuarios;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.lblNivelSeg = new System.Windows.Forms.Label();
            this.lblFechaReg = new System.Windows.Forms.Label();

            this.txtId = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtIntentos = new System.Windows.Forms.TextBox();
            this.txtNivelSeg = new System.Windows.Forms.TextBox();

            this.dtpFechaReg = new System.Windows.Forms.DateTimePicker();

            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();

            this.dgvUsuarios = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();

            // 
            // lblId
            //
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 15);
            this.lblId.Text = "ID:";

            //
            // txtId
            //
            this.txtId.Location = new System.Drawing.Point(130, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 23);
            this.txtId.ReadOnly = true;

            //
            // lblUsuario
            //
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(30, 70);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 15);
            this.lblUsuario.Text = "Usuario:";

            //
            // txtUsuario
            //
            this.txtUsuario.Location = new System.Drawing.Point(130, 67);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 23);

            //
            // lblContrasena
            //
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(30, 110);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(75, 15);
            this.lblContrasena.Text = "Contraseña:";

            //
            // txtContrasena
            //
            this.txtContrasena.Location = new System.Drawing.Point(130, 107);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(200, 23);
            this.txtContrasena.PasswordChar = '*';

            //
            // lblIntentos
            //
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(30, 150);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(52, 15);
            this.lblIntentos.Text = "Intentos:";

            //
            // txtIntentos
            //
            this.txtIntentos.Location = new System.Drawing.Point(130, 147);
            this.txtIntentos.Name = "txtIntentos";
            this.txtIntentos.Size = new System.Drawing.Size(200, 23);

            //
            // lblNivelSeg
            //
            this.lblNivelSeg.AutoSize = true;
            this.lblNivelSeg.Location = new System.Drawing.Point(30, 190);
            this.lblNivelSeg.Name = "lblNivelSeg";
            this.lblNivelSeg.Size = new System.Drawing.Size(72, 15);
            this.lblNivelSeg.Text = "Nivel Seg.:";

            //
            // txtNivelSeg
            //
            this.txtNivelSeg.Location = new System.Drawing.Point(130, 187);
            this.txtNivelSeg.Name = "txtNivelSeg";
            this.txtNivelSeg.Size = new System.Drawing.Size(200, 23);

            //
            // lblFechaReg
            //
            this.lblFechaReg.AutoSize = true;
            this.lblFechaReg.Location = new System.Drawing.Point(30, 230);
            this.lblFechaReg.Name = "lblFechaReg";
            this.lblFechaReg.Size = new System.Drawing.Size(75, 15);
            this.lblFechaReg.Text = "Fecha Reg.:";

            //
            // dtpFechaReg
            //
            this.dtpFechaReg.Location = new System.Drawing.Point(130, 227);
            this.dtpFechaReg.Name = "dtpFechaReg";
            this.dtpFechaReg.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            //
            // btnInsertar
            //
            this.btnInsertar.Location = new System.Drawing.Point(30, 280);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 35);
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);

            //
            // btnActualizar
            //
            this.btnActualizar.Location = new System.Drawing.Point(140, 280);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 35);
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            //
            // btnEliminar
            //
            this.btnEliminar.Location = new System.Drawing.Point(250, 280);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 35);
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            //
            // btnLimpiar
            //
            this.btnLimpiar.Location = new System.Drawing.Point(360, 280);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            //
            // dgvUsuarios
            //
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvUsuarios.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvUsuarios.Location = new System.Drawing.Point(390, 30);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvUsuarios.Size = new System.Drawing.Size(600, 220);

            this.dgvUsuarios.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvUsuarios_CellClick);

            //
            // Form1
            //
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1020, 360);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);

            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);

            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtContrasena);

            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.txtIntentos);

            this.Controls.Add(this.lblNivelSeg);
            this.Controls.Add(this.txtNivelSeg);

            this.Controls.Add(this.lblFechaReg);
            this.Controls.Add(this.dtpFechaReg);

            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);

            this.Controls.Add(this.dgvUsuarios);

            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Gestión de Usuarios";

            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

