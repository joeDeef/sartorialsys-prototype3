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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Empleado Registrado con exito");
            limpiarConsola();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarConsola();
        }

        private void limpiarConsola()
        {
            txtCédulaRegistrar.Text = "";
            txtNombresRegistrar.Text = "";
            txtDirecciónRegistrar.Text = "";
            txtTeléfonoRegistrar.Text = "";
            txtEmailRegistrar.Text = "";
            txtSalarioRegistrar.Text = "";
            txtHorarioRegistrar.Text = "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscarParaActualizar_Click(object sender, EventArgs e)
        {
            txtCédulaActualizar.Text = "1724915770";
            txtNombresActualizar.Text = "Alan Brito Delgado";
            txtDirecciónActualizar.Text = "La loma";
            txtTeléfonoActualizar.Text = "0994306989";
            txtEmailActualizar.Text = "alan.brito@epn.edu.ec";
            txtSalarioActualizar.Text = "450$";
            txtHorarioActualizar.Text = "8:00 - 13:00 y 14:00 - 17:00";
        }

        private void checkEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEmail.Checked)
            {
                txtEmailActualizar.Enabled = true;
            }
            else
            {
                txtEmailActualizar.Enabled = false;
            }
        }

        private void checkNombres_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNombres.Checked)
            {
                txtNombresActualizar.Enabled = true;
            }
            else
            {
                txtNombresActualizar.Enabled = false;
            }
        }

        private void checkDireccion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDireccion.Checked)
            {
                txtDirecciónActualizar.Enabled = true;
            }
            else
            {
                txtDirecciónActualizar.Enabled = false;
            }
        }

        private void checkTelefono_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkTelefono.Checked)
                {
                    txtTeléfonoActualizar.Enabled = true;
                }
                else
                {
                    txtTeléfonoActualizar.Enabled = false;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkSalarioActualizar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSalarioActualizar.Checked)
            {
                txtSalarioActualizar.Enabled = true;
            }
            else
            {
                txtSalarioActualizar.Enabled = false;
            }
        }

        private void checkHorarioActualizar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHorarioActualizar.Checked)
            {
                txtHorarioActualizar.Enabled = true;
            }
            else
            {
                txtHorarioActualizar.Enabled = false;
            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Empleado Actualizado con exito");
            limpiarActualizacion();
        }

        private void limpiarActualizacion()
        {
            txtParámetroParaActualizar.Text = "";
            txtCédulaActualizar.Text = "";
            txtNombresActualizar.Enabled = false;
            checkNombres.Checked = false;
            txtNombresActualizar.Text = "";
            txtDirecciónActualizar.Enabled = false;
            checkDireccion.Checked = false;
            txtDirecciónActualizar.Text = "";
            txtTeléfonoActualizar.Enabled = false;
            checkTelefono.Checked = false;
            txtTeléfonoActualizar.Text = "";
            txtEmailActualizar.Enabled = false;
            checkEmail.Checked = false;
            txtEmailActualizar.Text = "";
            txtSalarioActualizar.Enabled = false;
            checkSalarioActualizar.Checked = false;
            txtSalarioActualizar.Text = "";
            txtHorarioActualizar.Enabled = false;
            checkHorarioActualizar.Checked = false;
            txtHorarioActualizar.Text = "";
        }

        private void btnCancelarActualizacion_Click(object sender, EventArgs e)
        {
            limpiarActualizacion();
        }

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            limpiarConsulta();
        }

        private void limpiarConsulta()
        {
            txtParámetroBusqueda.Text = "";
            txtCédulaConsultar.Text = "";
            txtNombresConsultar.Text = "";
            txtDirecciónConsultar.Text = "";
            txtTeléfonoConsultar.Text = "";
            txtEmailConsultar.Text = "";
            txtSalarioConsultar.Text = "";
            txtHorarioConsultar.Text = "";
        }

        private void btnBuscarConsultar_Click(object sender, EventArgs e)
        {
            txtCédulaConsultar.Text = "1724915770";
            txtNombresConsultar.Text = "Alan Brito Delgado";
            txtDirecciónConsultar.Text = "La loma";
            txtTeléfonoConsultar.Text = "0994306989";
            txtEmailConsultar.Text = "alan.brito@epn.edu.ec";
            txtSalarioConsultar.Text = "450$";
            txtHorarioConsultar.Text = "8:00 - 13:00 y 14:00 - 17:00";
        }

        private void txtSalarioConsultar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarEliminar();
        }

        private void limpiarEliminar()
        {
            txtParámetroEliminar.Text = "";
            txtCédulaEliminar.Text = "";
            txtNombresEliminar.Text = "";
            txtDirecciónEliminar.Text = "";
            txtTeléfonoEliminar.Text = "";
            txtEmailEliminar.Text = "";
            txtSalarioEliminar.Text = "";
            txtHorarioEliminar.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Empleado eliminado con exito");
            limpiarEliminar();
        }

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            txtCédulaEliminar.Text = "1724915770";
            txtNombresEliminar.Text = "Alan Brito Delgado";
            txtDirecciónEliminar.Text = "La loma";
            txtTeléfonoEliminar.Text = "0994306989";
            txtEmailEliminar.Text = "alan.brito@epn.edu.ec";
            txtSalarioEliminar.Text = "450$";
            txtHorarioEliminar.Text = "8:00 - 13:00 y 14:00 - 17:00";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
