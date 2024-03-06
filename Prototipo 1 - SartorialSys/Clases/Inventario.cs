using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_1___SartorialSys.Clases
{
    internal class Inventario
    {
        static string strConn = ConexionBaseDeDatos.getConexion();
        static string strComm = null;
        static SqlConnection conn = null;
        static SqlCommand comm = null;
        internal static void actualizarInventario(string[,] items)
        {   
            int filas = items.GetLength(0);
            string comandoActualizarStock = "UPDATE productos SET cantidad_inicial = cantidad_inicial + ";
            for (int i = 0; i < filas; i++)
            {
                actualizarInventario(comandoActualizarStock,items[i,0], "-"+items[i,1]);
                comandoActualizarStock = "UPDATE productos SET cantidad_inicial = cantidad_inicial + ";
            }
        }

        internal static void actualizarInventario(string comando, string codigo, string cantidad)
        {
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                strComm = comando + cantidad + " WHERE codigo_producto = '"+codigo+"';";

                using (comm = new SqlCommand(strComm, conn))
                {
                    comm.ExecuteNonQuery();
                }
            }
        }
    }
}
