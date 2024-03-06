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
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand(getComandoFacturas(datos), conn, transaction);
                    command.ExecuteNonQuery();

                    if (items != null)
                    {
                        for (int i = 0; i < items.Length; i++)
                        {
                            SqlCommand command1 = new SqlCommand(getComandoItems(datos[0], items[i, 0], items[i,1]), conn, transaction);
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
                    }return false;
                }
            }
            return true;
        }

        private static string getComandoItems(string numero_factura, string columna1, string columna2)
        {
            return "INSERT INTO items VALUES('"+numero_factura+"','"+ columna1 + "',NULL," + columna2 +");";
        }

        private static string getComandoFacturas(string[] datos)
        {
            return "INSERT INTO facturas VALUES('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] +"');";
        }
    }
}
