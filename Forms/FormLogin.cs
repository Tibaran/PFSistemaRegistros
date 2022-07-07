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
    public partial class FormLogin : Form
    {
        CUsuarioBLL usuarioB = new CUsuarioBLL();
        Form alert;
        public FormLogin()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario resultado = usuarioB.BuscarPorUsernameAndPassword(txtUsername.Text, txtPassword.Text);
            if(resultado != null)
            {
                this.Hide();
                txtUsername.Text = "";
                txtPassword.Text = "";
                Form main = new MainForm(this);
                main.Show();
            }
            else
            {
                alert = new Alerts.ErrorGeneric("Usuario y/o contraseña incorrecta.");
                alert.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlRegistrase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            alert = new Alerts.InfoGeneric("Indique a su encargado que lo registre.");
            alert.Show();
        }

        private void panelHeaderLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
