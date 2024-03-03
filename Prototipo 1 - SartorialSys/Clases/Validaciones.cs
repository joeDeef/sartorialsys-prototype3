using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prototipo_1___SartorialSys.Clases
{
    internal class Validaciones
    {
        //Método Validar Correo
        public static bool ValidarCorreoElectronico(string correo)
        {
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(correo, patronCorreo);
        }

        //Método Validar Nombres
        public static bool validarNombrApellido(string nombre)
        {
            string patronNA = @"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ]+(?: [a-zA-ZáéíóúÁÉÍÓÚüÜñÑ]+)?$";
            return Regex.IsMatch(nombre, patronNA);
        }

        //Método Validadar Contraseña
        public static bool validarContraseña(string password)
        {
            string patronPass = @"^[a-zA-Z0-9#\$%&_!-]{8,12}$";
            return Regex.IsMatch(password, patronPass);
        }

        //

        internal static bool validarTelefono(string telefono)
        {
            string patronPass = @"^09\d{8}$";
            return Regex.IsMatch(telefono, patronPass);
        }
    }
}
