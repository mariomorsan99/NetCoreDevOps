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
    public class Consulta
    {
        public class ListaAutor:IRequest<List<AutorLibro>>{
        }

        public class Manejador:IRequestHandler<ListaAutor,List<AutorLibro>>
        {

            private readonly ContextoAutor _contexto;

            public Manejador(ContextoAutor contexto)
            {
                _contexto=contexto;
            } 
            public  async Task<List<AutorLibro>> Handle(ListaAutor request, CancellationToken cancellation)
            {
               
               var autores = await _contexto.AutorLibro.ToListAsync();
               return autores;

            }

        }
    }
}
