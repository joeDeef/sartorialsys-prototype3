using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Prototipo_1___SartorialSys.Clases
{
    internal class Ventas
    {
        static string strConn = ConexionBaseDeDatos.getConexion();
        static string strComm = null;
        static SqlConnection conn = null;
        static SqlCommand comm = null;
        internal static bool registrarVenta(string[] datos, string[,] items)
        {
            string numeroDeFactura = "001-001-" + getNumeroFac(getSigNumFact());
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand(getComandoFacturas(numeroDeFactura, datos), conn, transaction);
                    command.ExecuteNonQuery();

                    if (items != null)
                    {
                        SqlCommand command1 = new SqlCommand(getComandoItems(numeroDeFactura, items), conn, transaction);
                        command1.ExecuteNonQuery();
                    }
                    else
                    {
                        throw new Exception();
                    }

                    SqlCommand command2 = new SqlCommand("UPDATE parametros SET valor = (valor + 1) WHERE nombre = 'num_factura';", conn, transaction);
                    command2.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // En caso de error, revertir la transacción
                    Mensajes.emitirMensaje("Error 1: " + ex.Message);
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        Mensajes.emitirMensaje("Error al hacer rollback: " + exRollback.Message);
                        return false;
                    }return false;
                }
            }
            return true;
        }

        private static int getSigNumFact()
        {
            int num_factura;
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                strComm = "select valor from parametros WHERE nombre = 'num_factura'";
                using (comm = new SqlCommand(strComm, conn))
                {
                    SqlDataReader rdr = comm.ExecuteReader();
                    rdr.Read();
                    num_factura = Convert.ToInt32(rdr.GetDecimal(0));
                }
            }    
                return num_factura;
        }

        private static string getNumeroFac(int num_factura)
        {
            int digitos = num_factura.ToString().Length;
            string numero = "";
            for (int i = 0; i < (9 - digitos); i++)
            {
                numero += "0";
            }
            numero += num_factura.ToString();
            return numero;
        }

        private static string getComandoItems(string numero_factura, string[,] datosIngresar)
        { 
            string comandoFacturas = "INSERT INTO items VALUES";
            for (int i = 0; i < datosIngresar.GetLength(1); i++)
            {
                comandoFacturas += "('"+numero_factura+"','"+ datosIngresar[i,0] + "',NULL," + datosIngresar[i,1] +"), ";
            }
            return comandoFacturas.Substring(0, comandoFacturas.Length - 2) + ";";
        }

        private static string getComandoFacturas(string num_factura, string[] datos)
        {
            return "INSERT INTO facturas VALUES('"+num_factura + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] +"');";
        }

        internal static void consultarVenta(frmVentas frmVentas)
        {/*
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("Select", conn, transaction);
                    command.ExecuteNonQuery();

                    if (items != null)
                    {
                        for (int i = 0; i < items.GetLength(1) - 1; i++)
                        {
                            SqlCommand command1 = new SqlCommand(getComandoItems(datos[0], items[i, 0], items[i, 1]), conn, transaction);
                            command1.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // En caso de error, revertir la transacción
                    Mensajes.emitirMensaje("Error 1: " + ex.Message);
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        Mensajes.emitirMensaje("Error al hacer rollback: " + exRollback.Message);
                        return false;
                    }
                    return false;
                }
            }*/
        }
    }
}
