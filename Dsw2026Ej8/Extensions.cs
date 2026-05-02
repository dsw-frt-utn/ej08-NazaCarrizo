using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string cadena)
        {
            if (cadena == null)
            {
                return "SIN-CODIGO";
            }
            //Convertir la cadena a mayuscula
            string codigo=cadena.ToUpper();
            //Elimino el espacio en el inicio y al final si posee
            codigo = codigo.Trim();
            //reemplazo todo espacio restante con -
            codigo=codigo.Replace(" ", "-");

            return codigo;
        }
    }
}
