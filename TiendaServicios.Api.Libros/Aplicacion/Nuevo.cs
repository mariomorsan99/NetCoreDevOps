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
    public class Nuevo
    {
        public class Ejecuta: IRequest{
            
            public string Titulo{ get; set;}

            public DateTime? FechaPublicacion{ get; set;}

            public Guid? AutorLibro{ get; set;}


        }

        public class EjecutaValidacion: AbstractValidator<Ejecuta>
        {
           public EjecutaValidacion(){
               RuleFor(x => x.Titulo).NotNull();
               RuleFor(x => x.FechaPublicacion).NotNull();
           }
        }

        public class Manejador: IRequestHandler<Ejecuta>{


           private readonly ContextoLibreria _contexto;

           public Manejador(ContextoLibreria contexto)
           {
               _contexto=contexto;
           }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                  var libro= new LibreriaMateria{
                      Titulo=request.Titulo,
                      FechaPublicacion=request.FechaPublicacion,
                      AutorLibro=request.AutorLibro

                  };

                  _contexto.LibreriaMaterial.Add(libro);

                var valor=  await  _contexto.SaveChangesAsync();

                if(valor>0){
                    return Unit.Value;
                }

                throw new Exception("no se inserto el libro");

            }
        }


    }
}
