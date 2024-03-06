using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_1___SartorialSys.Clases
{
    internal class Productos
    {
        static string strConn = ConexionBaseDeDatos.getConexion();
        static string strComm = null;
        static SqlConnection conn = null;
        static SqlCommand comm = null;
        internal static string[] getColores()
        {
            int i = 0;
            string[] colores = new string[4];
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                strComm = "SELECT color FROM color";
                using (comm = new SqlCommand(strComm, conn))
                {
                    SqlDataReader rdr = comm.ExecuteReader();
                    while (rdr.Read())
                    {
                        colores[i] = rdr.GetString(0);
                        i++;
                    }
                    return colores;
                }
            }
        }

        internal static string[] getTallas()
        {
            int i = 0;
            string[] tallas = new string[4];
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                strComm = "SELECT talla FROM talla";
                using (comm = new SqlCommand(strComm, conn))
                {
                    SqlDataReader rdr = comm.ExecuteReader();
                    while (rdr.Read())
                    {
                        tallas[i] = rdr.GetString(0);
                        i++;
                    }
                    return tallas;
                }
            }
        }

        internal static bool registrarProducto(string[] datos)
        {
            using (conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    if (datos[4] != null)
                    {
                        strComm = getComando(datos);
                    }
                    else
                    {
                        strComm = getComandoNull(datos);
                    }
                    using (comm = new SqlCommand(strComm, conn))
                    {
                        if (comm.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        Mensajes.emitirMensaje("Producto ya registrado en el sistema " + ex.Message);
                        return false;
                    }
                    else
                    {
                        Mensajes.emitirMensaje("Error base de datos" + ex.Message);
                        return false;
                    }
                }
            }
            return false;
        }

        private static string getComandoNull(string[] datos)
        {
            return "INSERT INTO productos VALUES('" + datos[0] + "','" + datos[1] + "'," + getIDCategoria(datos[2]) + "," +
                getIdColor(datos[3]) + ",NULL,'" + datos[5] + "'," + datos[6] + ",NULL," + datos[8] + ",'" + datos[9] + "'," + getDia()+")";
        }

        private static string getDia()
        {
            return "(SELECT CAST(GETDATE() AS date))";
        }

        private static string getIdColor(string v)
        {
            return "(SELECT id_color from color WHERE color = '" + v + "')";
        }

        private static string getIDCategoria(string v)
        {
            return "(SELECT id_categoria FROM categoria WHERE categoria = '" + v + "')";
        }

        private static string getComando(string[] datos)
        {
            return "INSERT INTO productos VALUES('" + datos[0] + "','" + datos[1] + "'," + getIDCategoria(datos[2]) + "," +
                getIdColor(datos[3]) + ","+getIDTalla(datos[4]) +",'" + datos[5] + "'," + datos[6] + "," + datos[7] +"," + datos[8] + ",'" + datos[9] + "'," + getDia() + ");";
        }

        private static string getIDTalla(string v)
        {
            return "(SELECT id_talla FROM talla WHERE talla = '" + v + "')";
        }

        internal static bool buscarProducto(int i, string codigo, System.Windows.Forms.DataGridView listaProductos, string cantidad)
        {
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                strComm = "SELECT descripcion,precio_venta FROM productos WHERE codigo_producto = '" + codigo + "'";
                using (comm = new SqlCommand(strComm, conn))
                {
                    SqlDataReader rdr = comm.ExecuteReader();
                    rdr.Read();
                    if (rdr.HasRows)
                    {
                        int n = listaProductos.Rows.Add();
                        listaProductos.Rows[n].Cells[0].Value = i;
                        listaProductos.Rows[n].Cells[1].Value = codigo;
                        listaProductos.Rows[n].Cells[2].Value = rdr.GetString(0);
                        listaProductos.Rows[n].Cells[3].Value = cantidad;
                        listaProductos.Rows[n].Cells[4].Value = rdr.GetDecimal(1).ToString();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}