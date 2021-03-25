using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosWin
{
   public static class Datos
    {

        public static int[] Numeros = { 23, 89, 10, 5, 56, 12, 98, 76, 85, 42, 7, 18, 34, 15 };

        public static ArrayList MiLista = new ArrayList { 5, "hola", 89, 1.7, "sopa", 7.5, 45, "A", 32 };


        public static IList<Producto> Productos = new List<Producto>
        {
            new Producto{Codigo=1,Nombre="harina",Precio=7,Stock=56},
            new Producto{Codigo=2,Nombre="Leche",Precio=42,Stock=68},
            new Producto{Codigo=3,Nombre="Azucar",Precio=1,Stock=29},
            new Producto{Codigo=1,Nombre="Sal",Precio=2,Stock=516}
        };
    }
}
