using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Prototipo_1___SartorialSys.Clases;
using Prototipo_1___SartorialSys.Formularios;

namespace Prototipo_1___SartorialSys
{
    public partial class frmVentas : Form
    {
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 128, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }
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
                if(!Mensajes.confirmarAccion("Desea registrar al usuario"))
                {
                    Mensajes.emitirMensaje("Por favor llenar todos los campos");
                    vaciarDatos();
                    return;
                }
                frmClientes clientes = new frmClientes();
                clientes.ShowDialog();
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

        private void btnActualizarInformacion_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes(txtCedulaRegistrar.Text, 0);
            clientes.ShowDialog();
        }
    }
}
