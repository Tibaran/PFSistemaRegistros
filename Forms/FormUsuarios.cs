using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBLL;
using AppEntities;

namespace ProyectoFinal.Forms
{
    public partial class FormUsuarios : Form
    {
        CUsuarioBLL usuarioB = new CUsuarioBLL();
        Form alerta;
        Form confirmacion;
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            var resultado = usuarioB.BuscarPorUsername(txtUsername.Text);
            if (resultado == null)
            {
                Usuario nuevoUsuario = new Usuario();
                nuevoUsuario.Username = txtUsername.Text;
                nuevoUsuario.Password = txtPassword.Text;
                try
                {
                    usuarioB.Crear(nuevoUsuario);
                    Reset();
                    alerta = new Alerts.SuccessGeneric("Se registro la Entrada correctamente!");
                    alerta.Show();
                    RefreshDataGrid();
                }
                catch
                {
                    alerta = new Alerts.ErrorGeneric("Error al intenar crear usuario!.");
                    alerta.Show();
                }

            }
            else
            {
                alerta = new Alerts.ErrorGeneric("El usuario ya esta siendo usado.");
                alerta.Show();
            }

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            confirmacion = new Alerts.ChoiceGeneric("De editar al usuario: "+txtUsername.Text);
            foreach (Control c in confirmacion.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    if (c.Name == "btnAceptar")
                    {
                        c.Click += EditarUsuario;
                    }
                }
            }
            confirmacion.Show();
        }
        public void EditarUsuario(object sender, EventArgs e)
        {
            var resultado = usuarioB.BuscarPorId(Int32.Parse(txtId.Text));
            if (resultado != null)
            {

                resultado.Username = txtUsername.Text;
                resultado.Password = txtPassword.Text;

                usuarioB.Editar(resultado);
                alerta = new Alerts.SuccessGeneric("Se edito el usuario correctamente!");
                alerta.Show();
                RefreshDataGrid();
            }
            else
            {
                alerta = new Alerts.ErrorGeneric("No se puede editar al usuario.");
                alerta.Show();
            }
            confirmacion.Close();
        }


        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            confirmacion = new Alerts.ChoiceGeneric("De eliminar al usuario: "+txtUsername.Text);
            foreach (Control c in confirmacion.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    if (c.Name == "btnAceptar")
                    {
                        c.Click += EliminarUsuario;
                    }
                }
            }
            confirmacion.Show();
        }
        public void EliminarUsuario(object sender, EventArgs e)
        {
            var resultado = usuarioB.BuscarPorId(Int32.Parse(txtId.Text));
            if (resultado != null)
            {
                try
                {

                    var mensaje = usuarioB.Eliminar(resultado.UsuarioId);
                    alerta = new Alerts.SuccessGeneric(mensaje);
                    alerta.Show();
                    RefreshDataGrid();

                }
                catch
                {
                    alerta = new Alerts.ErrorGeneric("Error al intentar eliminar!");
                    alerta.Show();
                }

            }
            else
            {
                alerta = new Alerts.ErrorGeneric("El usuario no existe.");
                alerta.Show();
            }
            confirmacion.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            txtId.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        public void RefreshDataGrid()
        {
            dgvUsuarios.DataSource = usuarioB.ListarBLL();
            dgvUsuarios.Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dgvUsuarios.DataSource = usuarioB.ListarBLL();
            dgvUsuarios.Refresh();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {

                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                if (btns.GetType() == typeof(GroupBox))
                {
                    foreach (Control btnsIn in btns.Controls)
                    {
                        if (btnsIn.GetType() == typeof(Button))
                        {
                            Button btnIn = (Button)btnsIn;
                            btnIn.BackColor = ThemeColor.PrimaryColor;
                            btnIn.ForeColor = Color.White;
                            btnIn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                        }
                    }
                }
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                txtId.Text = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
                txtUsername.Text = dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString();
                txtPassword.Text = dgvUsuarios.SelectedRows[0].Cells[2].Value.ToString();
                
            }
        }
    }
}
