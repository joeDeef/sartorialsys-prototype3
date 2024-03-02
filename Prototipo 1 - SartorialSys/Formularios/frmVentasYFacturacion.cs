using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtCédulaRegistrar.Text = "";
            txtCódigoProductoRegistrar.Text = "";
            txtCantidadRegistrar.Text = "";
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

        private void btnBuscarConsultar_Click(object sender, EventArgs e)
        {
            txtCédulaConsultar.Text = "1724915770";
            txtNúmeroVentaConsultar.Text = "12";
            txtFechaEmisiónConsultar.Text = "12-01-2024";
            txtCódigoProductoConsultar.Text = "15";
            txtCantidadConsultar.Text = "2";
            txtSubtotalConsultar.Text = "60$";
            txtIvaConsultar.Text = "7.2$";
            txtTotalConsultar.Text = "67.2$";
            txtMétodoPagoConsultar.Text = "Efectivo";
        }

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            limpiarConsulta();
        }

        private void limpiarConsulta()
        {
            txtCédulaConsultar.Text = "";
            txtNúmeroVentaConsultar.Text = "";
            txtFechaEmisiónConsultar.Text = "";
            txtCódigoProductoConsultar.Text = "";
            txtCantidadConsultar.Text = "";
            txtSubtotalConsultar.Text = "";
            txtIvaConsultar.Text = "";
            txtTotalConsultar.Text = "";
            txtMétodoPagoConsultar.Text = "";
            txtParámetroBusqueda.Text = "";
        }

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            txtCédulaEliminar.Text = "1724915770";
            txtNémeroVentaEliminar.Text = "12";
            txtFechaEmisiónEliminar.Text = "12-01-2024";
            txtCódigoProductoEliminar.Text = "15";
            txtCantidadEliminar.Text = "2";
            txtSubtotalEliminar.Text = "60$";
            txtIvaEliminar.Text = "7.2$";
            txtTotalEliminar.Text = "67.2$";
            txtMétodoPagoEliminar.Text = "Efectivo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarEliminar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Venta eliminada con exito");
            limpiarEliminar();
        }

        private void limpiarEliminar()
        {
            txtCédulaEliminar.Text = "";
            txtNémeroVentaEliminar.Text = "";
            txtFechaEmisiónEliminar.Text = "";
            txtCódigoProductoEliminar.Text = "";
            txtCantidadEliminar.Text = "";
            txtSubtotalEliminar.Text = "";
            txtIvaEliminar.Text = "";
            txtTotalEliminar.Text = "";
            txtMétodoPagoEliminar.Text = "";
            txtParámetroEliminar.Text = "";
        }

        private void frmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
