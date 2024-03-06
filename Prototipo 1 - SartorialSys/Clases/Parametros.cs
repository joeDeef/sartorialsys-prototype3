using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_1___SartorialSys.Clases
{
    internal class Parametros
    {
        static string strConn = ConexionBaseDeDatos.getConexion();
        static string strComm = null;
        static SqlConnection conn = null;
        static SqlCommand comm = null;

        internal static decimal getIVA()
        {
                using (conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    strComm = "SELECT valor FROM parametros WHERE nombre = 'IVA'";
                    using (comm = new SqlCommand(strComm, conn))
                    {
                        SqlDataReader rdr = comm.ExecuteReader();
                        rdr.Read();
                        return rdr.GetDecimal(0);
                    }
                }
            }
    }
}
