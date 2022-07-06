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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gvEntradasListado.DataSource = entradaB.ListarPorFecha(dtpFechaBusqueda.Value.Date);
            gvEntradasListado.Refresh();
        }

        private void gvEntradasListado_SelectionChanged(object sender, EventArgs e)
        {
            if(gvEntradasListado.SelectedRows.Count > 0)
            {
                txtIdEntrada.Text = gvEntradasListado.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Form detalle = new Forms.FormDetalles(Int32.Parse(txtIdEntrada.Text));
            detalle.Show();
        }
    }
}
