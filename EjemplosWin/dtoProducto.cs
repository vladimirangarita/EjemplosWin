using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosWin
{
    public class dtoProducto
    {
        public string Nombre { get; set; }
        //Un detalle en el libro en la pagina 47 en el ejemplo de la creacion de esta
        //clase puente la propiedad precio esta en el libro de tipo string y en 
        //la Clase origen el campo precio es decimal
        public decimal Precio { get; set; }
    }
}
