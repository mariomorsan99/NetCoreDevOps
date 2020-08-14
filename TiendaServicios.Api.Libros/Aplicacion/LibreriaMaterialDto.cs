using System.Threading;
using System.Data;
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
using MediatR;
using TiendaServicios.Api.Libros.Persistencia;
using TiendaServicios.Api.Libros.Modelo;
using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace TiendaServicios.Api.Libros.Aplicacion
{
    public class LibreriaMaterialDto
    {
         public Guid? LibreriaMateriaId {get; set;}

        public  string Titulo { get; set;}

        public DateTime? FechaPublicacion{ get; set;}

        // public Guid? AutorLibro{ get; set;}
        
    }
}
