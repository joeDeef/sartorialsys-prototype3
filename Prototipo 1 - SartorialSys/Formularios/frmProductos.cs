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

namespace Prototipo_1___SartorialSys.Formularios
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            agregarOpciones();
        }

        private void agregarOpciones()
        {
            string[] colores = Productos.getColores();
            foreach (string color in colores) { 
                cmbColorRegistrar.Items.Add(color);
            }
            string[] tallas = Productos.getTallas();
            foreach (string talla in tallas)
            {
                cmbTallaRegistrar.Items.Add(talla);
            }
        }

        private void txtCodigoRegistrar_Leave(object sender, EventArgs e)
        {
            if (txtCodigoRegistrar.Text != "" && !Validaciones.esValidoCodigoProducto(txtCodigoRegistrar.Text))
            {
                Mensajes.emitirMensaje("Datos incorrectos");
                txtCodigoRegistrar.Text = "";
            }
        }

        private void txtDescripcionRegistrar_Leave(object sender, EventArgs e)
        {/*
            if (txtDescripcionRegistrar.Text != "" && !Validaciones.esValidoDescripcion(txtDescripcionRegistrar.Text))
            {
                Mensajes.emitirMensaje("Datos incorrectos");
                txtDescripcionRegistrar.Text = "";
            }*/
        }

        private void cmbCategoriaRegistrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCategoriaRegistrar.SelectedIndex != 0)
            {
                cmbTallaRegistrar.Enabled = false;
                txtPrecioVenta.Enabled = false;
            }
            else
            {
                cmbTallaRegistrar.Enabled = true;
            }
        }

        private void txtRUCProveedorRegistrar_Leave(object sender, EventArgs e)
        {
            if (txtRUCProveedorRegistrar.Text != "" && !Validaciones.esRUCValido(txtRUCProveedorRegistrar.Text))
            {
                Mensajes.emitirMensaje("Datos incorrectos");
                txtRUCProveedorRegistrar.Text = "";
            }
        }

        private void txtCantidadInicialRegistrar_Leave(object sender, EventArgs e)
        {
            if (txtCantidadInicialRegistrar.Text != "" && !Validaciones.esCantidadValida(txtCantidadInicialRegistrar.Text))
            {
                Mensajes.emitirMensaje("Datos incorrectos");
                txtCantidadInicialRegistrar.Text = "";
            }
        }

        private void txtPrecioCompraRegistrar_Leave(object sender, EventArgs e)
        {
            if (txtPrecioCompraRegistrar.Text != "" && !Validaciones.esCantidadDecimalValida(txtPrecioCompraRegistrar.Text))
            {
                Mensajes.emitirMensaje("Datos incorrectos");
                txtPrecioCompraRegistrar.Text = "";
            }
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text != "" && !Validaciones.esCantidadDecimalValida(txtPrecioCompraRegistrar.Text))
            {
                Mensajes.emitirMensaje("Datos incorrectos");
                txtPrecioVenta.Text = "";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string[] datos = getDatos();
            if (!Validaciones.estanLlenosLosCampos(datos))
            {
                Mensajes.emitirMensaje("Los datos no pueden estar vacíos - Por favor Llenar");
                txtPrecioVenta.Text = "";
                return;
            }
            if (!Productos.registrarProducto(datos))
            {
                Mensajes.emitirMensaje("Error al registrar el producto");
                return;
            }
            Mensajes.emitirMensaje("Producto registrado con éxito");
        }

        private string[] getDatos()
        {
            string[] datos = new string[10];
            datos[0] = txtCodigoRegistrar.Text;
            datos[1] = txtDescripcionRegistrar.Text;
            datos[2] = cmbCategoriaRegistrar.Text;
            datos[3] = cmbColorRegistrar.Text;
            if(cmbCategoriaRegistrar.Text == "Prenda")
            {
                datos[4] = cmbTallaRegistrar.Text;
                datos[8] = txtPrecioVenta.Text;
            }
            else
            {
                datos[4] = null;
                datos[8] = null;
            }
            datos[5] = txtRUCProveedorRegistrar.Text;
            datos[6] = txtCantidadInicialRegistrar.Text;
            datos[7] = txtPrecioCompraRegistrar.Text;
            datos[9] = dtpFechaRegistro.ToString();
            return datos;
        }
    }
}
