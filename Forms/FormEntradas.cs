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
            Entrada nuevaEntrada = new Entrada();
            nuevaEntrada.FechaHora = dtpFechaHora.Value;
            nuevaEntrada.PersonaId = personaB.BuscarPorDni(txtDni.Text).PersonaId;
            nuevaEntrada.Destino = txtDestino.Text;
            nuevaEntrada.Motivo = rtxtMotivo.Text;

            entradaB.CrearEntrada(nuevaEntrada);
            Reset();
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
        }

        private void btnActualizarFecha_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            dtpFechaHora.Value = localDate;
        }
    }
}
