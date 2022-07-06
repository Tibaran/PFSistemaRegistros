using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBLL;
using AppEntities;

namespace ProyectoFinal.Forms
{
    public partial class FormDetalles : Form
    {
        CEntradaBLL entradaB = new CEntradaBLL();
        CPersonaBLL personaB = new CPersonaBLL();
        Form alerta;
        private int entradaId;
        public FormDetalles(int entradaId)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.entradaId = entradaId;
            LLenarDatos();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void LoadTheme()
        {
            panelDetallesHead.BackColor = ThemeColor.PrimaryColor;
            foreach (Control btns in this.Controls)
            {

                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        public void LLenarDatos()
        {
            var entradaRes = entradaB.BuscarPorId(entradaId);
            if( entradaRes != null)
            {
                txtIdEntrada.Text = entradaRes.EntradaId.ToString();
                txtFecha.Text = entradaRes.Fecha.ToString();
                txtHora.Text = entradaRes.Hora.ToString();
                txtDestino.Text = entradaRes.Destino;
                txtMotivo.Text = entradaRes.Motivo;
                var personaRes = personaB.BuscarPorId(entradaRes.PersonaId);
                if(personaRes != null)
                {
                    txtNombre.Text = personaRes.Nombre;
                    txtApellido.Text = personaRes.Apellido;
                    txtDni.Text = personaRes.DNI;
                    txtEdad.Text = personaRes.Edad.ToString();
                    txtSexo.Text = personaRes.Sexo;
                }
                else
                {
                    alerta = new Alerts.ErrorGeneric("No se encontro a: " + entradaRes.PersonaId);
                    alerta.Show();
                }
            }
            else
            {
                alerta = new Alerts.ErrorGeneric("No se encontro registros con Id: " + entradaId);
                alerta.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetalles_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void panelDetallesHead_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
