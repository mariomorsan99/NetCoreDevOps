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
using AutoMapper;

namespace TiendaServicios.Api.Autor.Aplicacion
{
    public class ConsultaFiltro
    {
        public class AutorUnico: IRequest<AutorDto>{
               public string AutorGuid{ get; set;}
        }

        public class Manejador: IRequestHandler<AutorUnico, AutorDto>
        {
            private readonly ContextoAutor _contexto;
            private readonly IMapper _mapper;

            public Manejador( ContextoAutor  contexto, IMapper mapper)
            {
                _contexto=contexto;
                _mapper=mapper;
            }
            public async Task<AutorDto> Handle(AutorUnico request, CancellationToken cancellation)
            {
                var autor= await _contexto.AutorLibro.Where(x=>x.AutorLibroGuid==request.AutorGuid).FirstOrDefaultAsync();
               
                if(autor == null)
                {
                    throw new Exception("No se encontro el autor");
                }

                 var autoresDto= _mapper.Map<AutorLibro,AutorDto>(autor);
                return autoresDto;
            }
           
        }
        
        
    }
}
