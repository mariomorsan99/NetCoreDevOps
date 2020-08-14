using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicios.Api.Autor.Modelo
{
    public class AutorLibro
    {
        public int AutorLibroid {get; set;}

        public string Nombre { get; set;}

        public string Apellido {get; set;}

        public DateTime? FechaNacimiento {get; set;}

        public ICollection<GradoAcademico> ListaGrados{  get; set;}

        public string? AutorLibroGuid { get; set;}



    }
}
