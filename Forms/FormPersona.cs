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
    public partial class FormPersona : Form
    {
        CPersonaBLL personaB = new CPersonaBLL();
        CEntradaBLL entradaB = new CEntradaBLL();
        Form alerta;
        Form confirmacion;
        public FormPersona()
        {
            InitializeComponent();
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

        private void FormPersona_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dgvPersonas.DataSource = personaB.ListarBLL();
            dgvPersonas.Refresh();
        }
        private void Reset()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            nudEdad.Value = 0;
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
        }

        private void btnRegistrarPersona_Click(object sender, EventArgs e)
        {
            var resultado = personaB.BuscarPorDni(txtDni.Text);
            if (resultado == null)
            {
                CPersona nuevaPersona = new CPersona();
                nuevaPersona.Nombre = txtNombre.Text;
                nuevaPersona.Apellido = txtApellido.Text;
                nuevaPersona.DNI = txtDni.Text;
                nuevaPersona.Edad = (int)nudEdad.Value;
                if (rbMasculino.Checked)
                {
                    nuevaPersona.Sexo = "M";
                }
                if (rbFemenino.Checked)
                {
                    nuevaPersona.Sexo = "F";
                }
                try
                {
                    personaB.Crear(nuevaPersona);
                    Reset();
                    alerta = new Alerts.SuccessGeneric("Se registro la Entrada correctamente!");
                    alerta.Show();
                    RefreshDataGrid();
                }
                catch
                {
                    alerta = new Alerts.ErrorGeneric("Error al intenar crear persona!.");
                    alerta.Show();
                }
                
            }
            else
            {
                alerta = new Alerts.ErrorGeneric("El DNI ya esta siendo usado.");
                alerta.Show();
            }
        }
        

        private void btnEditarPersona_Click(object sender, EventArgs e)
        {
            confirmacion = new Alerts.ChoiceGeneric("De editar a la persona: " + txtDni.Text);
            foreach (Control c in confirmacion.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    if (c.Name == "btnAceptar")
                    {
                        c.Click += EditarPersona;
                    }
                }
            }
            confirmacion.Show();
        }
        private void EditarPersona(object sender, EventArgs e)
        {
            var resultado = personaB.BuscarPorDni(txtDni.Text);
            if (resultado != null)
            {

                resultado.Nombre = txtNombre.Text;
                resultado.Apellido = txtApellido.Text;
                resultado.DNI = txtDni.Text;
                resultado.Edad = (int)nudEdad.Value;
                if (rbMasculino.Checked)
                {
                    resultado.Sexo = "M";
                }

                if (rbFemenino.Checked)
                {
                    resultado.Sexo = "F";
                }
                personaB.Editar(resultado);
                alerta = new Alerts.SuccessGeneric("Se edito a la persona correctamente!");
                alerta.Show();
                RefreshDataGrid();
            }
            else
            {
                alerta = new Alerts.ErrorGeneric("No se puede editar a la persona.");
                alerta.Show();
            }
            confirmacion.Close();

        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            confirmacion = new Alerts.ChoiceGeneric("De eliminar a la persona: "+txtDni.Text);
            foreach (Control c in confirmacion.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    if (c.Name == "btnAceptar")
                    {
                        c.Click +=Eliminacion;
                    }
                }
            }
            confirmacion.Show();

        }
        private void Eliminacion(object sender, EventArgs e)
        {
            var resultado = personaB.BuscarPorDni(txtDni.Text);
            if (resultado != null)
            {
                try
                {
                    var datosExistentes = entradaB.BuscarPorIdPersona(resultado.PersonaId);
                    if (datosExistentes != null)
                    {
                        alerta = new Alerts.ErrorGeneric("La persona no se puede eliminar, tiene registros!");
                        alerta.Show();
                    }
                    else
                    {
                        var mensaje = personaB.Eliminar(resultado.PersonaId);
                        alerta = new Alerts.SuccessGeneric(mensaje);
                        alerta.Show();
                        RefreshDataGrid();
                    }

                }
                catch
                {
                    alerta = new Alerts.ErrorGeneric("Error al intentar eliminar!");
                    alerta.Show();
                }

            }
            else
            {
                alerta = new Alerts.ErrorGeneric("La persona no existe.");
                alerta.Show();
            }
            confirmacion.Close();
        }

        private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {
                txtNombre.Text = dgvPersonas.SelectedRows[0].Cells[1].Value.ToString();
                txtApellido.Text = dgvPersonas.SelectedRows[0].Cells[2].Value.ToString();
                txtDni.Text = dgvPersonas.SelectedRows[0].Cells[3].Value.ToString();
                nudEdad.Value = Int32.Parse(dgvPersonas.SelectedRows[0].Cells[4].Value.ToString());
                if(dgvPersonas.SelectedRows[0].Cells[5].Value.ToString() == "M")
                {
                    rbMasculino.Checked = true;
                }
                else
                {
                    rbFemenino.Checked = true;
                }
            }
        }

        public void RefreshDataGrid()
        {
            dgvPersonas.DataSource = personaB.ListarBLL();
            dgvPersonas.Refresh();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
