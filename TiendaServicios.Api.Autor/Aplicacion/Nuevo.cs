using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using TiendaServicios.Api.Autor.Persistencia;
using TiendaServicios.Api.Autor.Modelo;

namespace TiendaServicios.Api.Autor.Aplicacion
{
    public class Nuevo
    {
        public class Ejecuta :IRequest {

           public string Nombre{ get; set;}

           public string Apellido{ get; set;}

           public DateTime? FechaNacimiento{get; set;}

           public string AutorLibroGuid{get; set;}

        }

        public class Manejador: IRequestHandler<Ejecuta>{

            public readonly ContextoAutor _contesto;

            public Manejador(ContextoAutor contexto){
                _contesto=contexto;
            }

            public async Task<Unit> Handle (Ejecuta request, CancellationToken cancellationToken)
            {
                var autorLibro= new AutorLibro{
                    Nombre=request.Nombre,
                    Apellido=request.Apellido,
                    FechaNacimiento=request.FechaNacimiento,
                    AutorLibroGuid= Convert.ToString(Guid.NewGuid())
                };

                _contesto.AutorLibro.Add(autorLibro);
               var valor=  await _contesto.SaveChangesAsync();
                
               if(valor>0){
                   return Unit.Value;
               }

               throw new Exception("no se logro la insercion");

            }

        }

    }
}
