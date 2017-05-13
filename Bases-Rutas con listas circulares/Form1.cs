using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bases_Rutas_con_listas_circulares
{
    public partial class frmPrincipal : Form
    {
        Ruta ruta;
        public frmPrincipal()
        {
            InitializeComponent();
            ruta = new Ruta();
        }

		public void limpiar()
		{
			txtNombre.Clear();
			txtMinutos.Clear();
			txtConsola.Clear();
		}

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            Base base1 = new Base(txtNombre.Text, Convert.ToInt32(txtMinutos.Text));
            ruta.agregar(base1);
			limpiar();
			txtNombre.Focus();
        }

		private void bntBuscar_Click(object sender, EventArgs e)
		{
			if (ruta.buscar(txtNombre.Text)!=null)
			{
				txtConsola.Text = ruta.buscar(txtNombre.Text).ToString();
			}else
			{
				txtConsola.Clear();
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			ruta.eliminar(txtNombre.Text);
			limpiar();
		}

		private void btnReporte_Click(object sender, EventArgs e)
		{
			txtConsola.Text=ruta.reporte();
		}

		private void btnEliminarPrimero_Click(object sender, EventArgs e)
		{
			ruta.eliminarInicio();
		}

		private void btnBorrarUltimo_Click(object sender, EventArgs e)
		{
			ruta.eliminarUltimo();
		}

		private void btnInsertar_Click(object sender, EventArgs e)
		{
			Base base1 = new Base(txtNombre.Text, Convert.ToInt32(txtMinutos.Text));
			ruta.insertarDespuesDe(txtInsertar.Text, base1);
		}
	}
}
