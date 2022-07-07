using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEntities;
using AppBLL;

namespace ProyectoFinal.Forms
{
    public partial class FormEntradas : Form
    {
        CEntradaBLL entradaB = new CEntradaBLL();
        CPersonaBLL personaB = new CPersonaBLL();
        Form alerta;
        public FormEntradas()
        {
            InitializeComponent();
            DateTime localDate = DateTime.Now;
            dtpFechaHora.Value = localDate;
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

        private void FormEntradas_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            var personaDni = personaB.BuscarPorDni(txtDni.Text);
            if(personaDni != null)
            {
                registrar(personaDni);
            }
            else
            {
                alerta = new Alerts.ErrorGeneric("No se encontro registros con dni: "+txtDni.Text);
                alerta.Show();
            }

        }
        private void registrar(CPersona persona)
        {
            Entrada nuevaEntrada = new Entrada();
            nuevaEntrada.Fecha = dtpFechaHora.Value.Date;
            nuevaEntrada.Hora = dtpFechaHora.Value.TimeOfDay;
            nuevaEntrada.PersonaId = persona.PersonaId;
            nuevaEntrada.Destino = txtDestino.Text;
            nuevaEntrada.Motivo = rtxtMotivo.Text;
            entradaB.CrearEntrada(nuevaEntrada);
            Reset();
            alerta = new Alerts.SuccessGeneric("Se registro la Entrada correctamente!");
            alerta.Show();
        }
        private void Reset()
        {
            DateTime localDate = DateTime.Now;
            dtpFechaHora.Value = localDate;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtDestino.Text = "";
            rtxtMotivo.Text = "";
            nudEdad.Value = 0;
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
        }

        private void btnActualizarFecha_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            dtpFechaHora.Value = localDate;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var resultado = personaB.BuscarPorDni(txtBusqueda.Text);
            if(resultado != null)
            {
                txtNombre.Text = resultado.Nombre;
                txtApellido.Text = resultado.Apellido;
                txtDni.Text = resultado.DNI;
                nudEdad.Value = resultado.Edad;
                if(resultado.Sexo == "M")
                {
                    rbMasculino.Checked = true;
                }
                if (resultado.Sexo == "F")
                {
                    rbFemenino.Checked = true;
                }
            }
            else
            {
                alerta = new Alerts.ErrorGeneric("El DNI es incorrecto o no existe.");
                alerta.Show();
            }
            
        }

        private void btnRegistrarPersona_Click(object sender, EventArgs e)
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
            else
            if (rbFemenino.Checked)
            {
                nuevaPersona.Sexo = "F";
            }
            try
            {
                personaB.Crear(nuevaPersona);
                alerta = new Alerts.SuccessGeneric("Se registro a la persona correctamente!");
                alerta.Show();
            }
            catch
            {
                alerta = new Alerts.ErrorGeneric("Error al registrar a: "+txtDni.Text);
                alerta.Show();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
