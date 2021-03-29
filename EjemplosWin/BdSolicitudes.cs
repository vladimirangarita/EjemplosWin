using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosWin
{

    public class Caso
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdSubCategoria { get; set; }
        public int Duracion { get; set; }
        public string Descripcion { get; set; }
        public string Estatus { get; set; }

    }


    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class SubCategoria
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }

        public string Nombre { get; set; }

    }

    public class BdSolicitudes : IDisposable
    {
        public List<Caso> Casos
        {
            get
            {
                var lCasos = new List<Caso>
                {
                    new Caso { Id=1,Fecha=Convert.ToDateTime("04/07/2015"),IdSubCategoria=1,Duracion=20,Descripcion="pintura de la sala principal",Estatus="A"},
                    new Caso { Id = 2, Fecha = Convert.ToDateTime("03/08/2015"), IdSubCategoria = 7, Duracion = 0, Descripcion = "Cambio de Monitor", Estatus = "R" },
                    new Caso { Id = 3, Fecha = Convert.ToDateTime("24/07/2015"), IdSubCategoria = 3, Duracion = 1, Descripcion = "Instalacion de Office", Estatus = "C" },
                    new Caso { Id = 4, Fecha = Convert.ToDateTime("07/08/2015"), IdSubCategoria = 4, Duracion = 3, Descripcion = "Eliminación de Virus", Estatus = "P" },
                    new Caso { Id = 5, Fecha = Convert.ToDateTime("17/08/2015"), IdSubCategoria = 1, Duracion = 17, Descripcion = "Pintar Oficina", Estatus = "P" },
                    new Caso { Id = 6, Fecha = Convert.ToDateTime("22/05/2015"), IdSubCategoria = 3, Duracion = 1, Descripcion = "Instalacion de Project", Estatus = "A" },
                    new Caso { Id = 7, Fecha = Convert.ToDateTime("12/06/2015"), IdSubCategoria = 2, Duracion = 0, Descripcion = "Reemplazar Vidrio", Estatus = "R" },
                    new Caso { Id = 8, Fecha = Convert.ToDateTime("09/09/2015"), IdSubCategoria = 8, Duracion = 2, Descripcion = "4500", Estatus = "A" },
                    new Caso { Id = 9, Fecha = Convert.ToDateTime("26/06/2015"), IdSubCategoria = 9, Duracion = 8, Descripcion = "Nuevo Reporte", Estatus = "P" },
                    new Caso { Id = 10, Fecha = Convert.ToDateTime("23/06/2015"), IdSubCategoria = 8, Duracion = 0, Descripcion = "25000", Estatus = "R" },
                    new Caso { Id = 11, Fecha = Convert.ToDateTime("02/06/2015"), IdSubCategoria = 7, Duracion = 23, Descripcion = "Portatil", Estatus = "C" },
                    new Caso { Id = 12, Fecha = Convert.ToDateTime("18/05/2015"), IdSubCategoria = 2, Duracion = 7, Descripcion = "Reemplazo", Estatus = "C" },
                    new Caso { Id = 13, Fecha = Convert.ToDateTime("19/05/2015"), IdSubCategoria = 6, Duracion = 2, Descripcion = "7 dias el 19-07", Estatus = "A" }
                };
                return lCasos;
            }
        }
        public List<Categoria> Categorias
        {
            get
            {
                var lCategorias = new List<Categoria>
                {
                    new Categoria{ Id = 1, Nombre = "Mantenimiento General"},
                    new Categoria{ Id = 2, Nombre = "Informatica"},
                    new Categoria{ Id = 3, Nombre = "Recursos Humanos"}
                };
                return lCategorias;
            }
        }
        public List<SubCategoria> SubCategorias
        {
            get
            {
                var lSubCategorias = new List<SubCategoria>
                {
                    new SubCategoria { Id = 1, IdCategoria = 1, Nombre = "Pintura"},
                    new SubCategoria { Id = 2, IdCategoria = 1, Nombre = "Ventanas"},
                    new SubCategoria { Id = 3, IdCategoria = 2, Nombre = "Instalacion de Aplicación"},
                    new SubCategoria { Id = 4, IdCategoria = 2, Nombre = "Virus"},
                    new SubCategoria { Id = 5, IdCategoria = 1, Nombre = "Filtraciones"},
                    new SubCategoria { Id = 6, IdCategoria = 3, Nombre = "Vacaciones"},
                    new SubCategoria { Id = 7, IdCategoria = 2, Nombre = "Solicitud de Equipos"},
                    new SubCategoria { Id = 8, IdCategoria = 3, Nombre = "Anticipos"}
                };
                return lSubCategorias;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
