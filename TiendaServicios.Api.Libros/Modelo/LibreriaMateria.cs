using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TiendaServicios.Api.Libros.Modelo
{
    public class LibreriaMateria
    {
        public Guid? LibreriaMateriaId {get; set;}

        public  string Titulo { get; set;}

        public DateTime? FechaPublicacion{ get; set;}

        public Guid? AutorLibro{ get; set;}

        // public string LibreriaMateriaGuid { get; set;}



    }
}
