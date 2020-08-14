using System.Reflection.Metadata;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using TiendaServicios.Api.Autor.Persistencia;
using TiendaServicios.Api.Autor.Modelo;
using Microsoft.EntityFrameworkCore;

namespace TiendaServicios.Api.Autor.Aplicacion
{
    public class ConsultaFiltro
    {
        public class AutorUnico: IRequest<AutorLibro>{
               public string AutorGuid{ get; set;}
        }

        public class Manejador: IRequestHandler<AutorUnico, AutorLibro>
        {
            private readonly ContextoAutor _contexto;

            public Manejador( ContextoAutor  contexto)
            {
                _contexto=contexto;
            }
            public async Task<AutorLibro> Handle(AutorUnico request, CancellationToken cancellation)
            {
                var autor= await _contexto.AutorLibro.Where(x=>x.AutorLibroGuid==request.AutorGuid).FirstOrDefaultAsync();
                if(autor == null)
                {
                    throw new Exception("No se encontro el autor");
                }
                return autor;
            }
           
        }
        
        
    }
}
