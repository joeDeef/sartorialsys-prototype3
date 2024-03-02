using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_1___SartorialSys.Clases
{
    internal class Login
    {
        internal static bool verificarCredenciales(string usuario, string contraseña)
        {
            if (estanVaciosLosCampos(usuario, contraseña))
            {
                Mensajes.emitirMensaje("Los campos no pueden estar vacíon - Por favor llenar");
                return false;
            }
            string strConn = ConexionBaseDeDatos.getConexion();
            string strComm = null;
            SqlConnection conn = null;
            SqlCommand comm = null;
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                strComm = "SELECT * FROM usuarios WHERE usuario = '" + usuario + "'";
                using (comm = new SqlCommand(strComm, conn))
                {

                    SqlDataReader rdr = comm.ExecuteReader();
                    rdr.Read();
                    if (!rdr.HasRows)
                    {
                        Mensajes.emitirMensaje("Usuario no registrado");
                        return false;
                    }
                    if (!estaActivo(usuario))
                    {
                        Mensajes.emitirMensaje("Usuario no existente");
                        return false;
                    }
                    if (contraseña != rdr.GetString(1))
                    {
                        Mensajes.emitirMensaje("Contraseñas Incorrectas");
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool estaActivo(string usuario)
        {
            string strConn = ConexionBaseDeDatos.getConexion();
            string strComm = null;
            SqlConnection conn = null;
            SqlCommand comm = null;
            bool activo;
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                strComm = "SELECT * FROM usuarios WHERE usuario = '" + usuario + "'";
                using (comm = new SqlCommand(strComm, conn))
                {
                    SqlDataReader rdr = comm.ExecuteReader();
                    rdr.Read();
                    activo = rdr.GetBoolean(4);
                }
            }
            return activo;
        }

        private static bool estanVaciosLosCampos(string usuario, string contraseña)
        {
            if ((usuario == "" && contraseña == "") || (usuario == "USUARIO") && (contraseña == "CONTRASEÑA"))
            {
                return true;
            }
            if (contraseña == "CONTRASEÑA" || usuario == "USUARIO")
            {
                return true;
            }
            return false;
        }
    }
}
