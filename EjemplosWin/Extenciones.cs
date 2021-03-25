using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosWin
{
    public static class Extenciones
    {
        public static string Left(this string valor, int caracteres)
        {
            return valor.Substring(0, caracteres);
        }


        public static string Right (this string valor, int caracteres)
        {
            int largo = valor.Length;
            return valor.Substring(largo - caracteres, caracteres);
        }
    }
}
