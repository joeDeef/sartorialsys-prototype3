using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototipo_1___SartorialSys.Clases;
using Prototipo_1___SartorialSys.Formularios;

namespace Prototipo_1___SartorialSys
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Venta Registrada con exito");
            limpiarConsola();
        }

        private void limpiarConsola()
        {
            txtCedulaRegistrar.Text = "";
            txtSubtotalRegistrar.Text = "";
            txtIvaRegistrar.Text = "";
            txtTotalRegistrar.Text = "";

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarConsola();
        }


        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Venta eliminada con exito");
        }

        private void frmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            string[] datosCliente = Cliente.buscarCliente(txtCedulaRegistrar.Text);
            if (!existeRegistro(datosCliente[0]))
            {
                Mensajes.emitirMensaje("Cliente no registrado - Por favor llenar los demas datos");
                vaciarDatos();
                return;
            }
            txtCedulaRegistrar.Text = datosCliente[0];
            txtNombresRegistrar.Text = datosCliente[1];
            txtApellidosRegistrar.Text = datosCliente[2];
            txtDireccionRegistrar.Text = datosCliente[3];
            txtCorreoRegistrar.Text = datosCliente[4];
            txtTelefonoRegistrar.Text = datosCliente[5];
        }

        private void vaciarDatos()
        {
            txtCedulaRegistrar.Text = "";
            txtNombresRegistrar.Text = "";
            txtApellidosRegistrar.Text = "";
            txtDireccionRegistrar.Text = "";
            txtCorreoRegistrar.Text = "";
            txtTelefonoRegistrar.Text = "";
        }

        private bool existeRegistro(string cedula)
        {
            return cedula != null;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAgregarProducto agregarProducto = new frmAgregarProducto(dgtvListaProductos);
            agregarProducto.ShowDialog();
        }

        private void btnBuscarConsultar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
