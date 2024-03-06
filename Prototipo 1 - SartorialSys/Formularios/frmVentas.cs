using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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
        bool permiso;
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 128, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }
        public frmVentas(bool permiso)
        {
            InitializeComponent();
            this.permiso = permiso;
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
            txtSubtotalRegistrar.Text = getSumatoria();
            txtIvaRegistrar.Text = getIVA();
            txtTotalRegistrar.Text = getTotal();
        }

        private string getTotal()
        {
            return (Convert.ToInt32(txtSubtotalRegistrar.Text) + Convert.ToDecimal(txtIvaRegistrar.Text)).ToString();
        }

        private string getIVA()
        {
            return (Convert.ToInt32(txtSubtotalRegistrar.Text) * (Parametros.getIVA())).ToString();
        }

        private string getSumatoria()
        {
            int subtotal = 0;
            foreach (DataGridViewRow fila in dgtvListaProductos.Rows)
            {
                subtotal += Convert.ToInt32((fila.Cells[4].Value))*Convert.ToInt32((fila.Cells[3].Value));
            }
            return subtotal.ToString();
        }

        private void btnBuscarConsultar_Click_1(object sender, EventArgs e)
        {
            Ventas.consultarVenta(this);
        }

        private void btnActualizarInformacion_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes(txtCedulaRegistrar.Text, 0);
            clientes.ShowDialog();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            string[] datos = getDatoVenta();
            if (!Validaciones.estanLlenosLosCampos(datos))
            {
                Mensajes.emitirMensaje("Los datos no pueden estar vacíos - Por favor Llenar");
                return;
            }
            if (!Ventas.registrarVenta(datos, getItems()))
            {
                Mensajes.emitirMensaje("Error al registrar la venta");
                return;
            }
            else 
            { 
            Mensajes.emitirMensaje("Venta registrada con éxito"); 
            }
        }

        private string[,] getItems()
        {
            int filas = dgtvListaProductos.RowCount-1;
            string[,] items = new string[filas,2];
            for (int i = 0; i < filas; i++)
            {
                items[i,0] = dgtvListaProductos.Rows[i].Cells[1].Value.ToString();
                items[i,1] = dgtvListaProductos.Rows[i].Cells[3].Value.ToString();
            }
            return items;
        }
        private string[] getDatoVenta()
        {
            string[] datos = new string[5];
            datos[1] = txtCedulaRegistrar.Text;
            DateTime fechaSeleccionada = dtpFechaVenta.Value;
            datos[2] = fechaSeleccionada.ToString("yyyy-MM-dd");
            datos[3] = cmbMetodoPago.Text;
            if(cmbEstadoPago.Text == "Pagado")
            {
                datos[4] = "1";
            }
            else
            {
                datos[4] = "0";
            }
            return datos;
        }

        private void txtCedulaRegistrar_Leave(object sender, EventArgs e)
        {
            if (txtCedulaRegistrar.Text != "")
            {
                if (!ValidarCedula.validarCedula(txtCedulaRegistrar.Text))
                {
                    Mensajes.emitirMensaje("Número de Cédula inválida");
                    txtCedulaRegistrar.Text = "";
                    txtCedulaRegistrar.Focus();
                }
            }
        }
    }
}
