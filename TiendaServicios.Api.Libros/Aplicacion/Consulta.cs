using System.Reflection.Metadata;
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
using AutoMapper;

namespace TiendaServicios.Api.Libros.Aplicacion
{
    public class Consulta
    {
        public class Libreria:IRequest<List<LibreriaMaterialDto>>{}

        public class Manejador :IRequestHandler<Libreria,List<LibreriaMaterialDto>>
        {
             private readonly ContextoLibreria _contexto;
             private readonly IMapper _mapper;

             public Manejador( ContextoLibreria contexto, IMapper mapper)
             {
                 _contexto=contexto;
                 _mapper=mapper;
             }

             public async Task<List<LibreriaMaterialDto>> Handle(Libreria request, CancellationToken cancellationToken)
             {
                 var libros= await _contexto.LibreriaMaterial.ToListAsync();
                 var libroDto= _mapper.Map<List<LibreriaMateria>, List<LibreriaMaterialDto>>(libros);
                 return libroDto;
             }
        }
    }
}
