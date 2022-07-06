using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEntities;
using AppBLL;

namespace ProyectoFinal.Forms
{
    public partial class FormListadoEntradas : Form
    {
        CEntradaBLL entradaB = new CEntradaBLL();
        public FormListadoEntradas()
        {
            InitializeComponent();
        }

        private void FormListadoEntradas_Load(object sender, EventArgs e)
        {
            LoadTheme();
            gvEntradasListado.DataSource = entradaB.ListarBLL();
            gvEntradasListado.Refresh();
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
            }
        }
    }
}
