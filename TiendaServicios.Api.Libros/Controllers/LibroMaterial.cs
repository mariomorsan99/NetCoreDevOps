using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using TiendaServicios.Api.Libros.Aplicacion;
using TiendaServicios.Api.Libros.Modelo;

namespace TiendaServicios.Api.Libros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibroMaterialController : ControllerBase
    {
          private readonly IMediator _mediator;
        
         public LibroMaterialController(IMediator mediator)
        {
            _mediator=mediator;
        }

        [HttpPost]
        public async Task <ActionResult<Unit>> Crear(Nuevo.Ejecuta data) 
        {
              return await _mediator.Send(data);
        }

        [HttpGet]
        public async Task <ActionResult<List<LibreriaMaterialDto>>> GetLibros()
        {
              return await _mediator.Send(new Consulta.Libreria());
        }

        [HttpGet("{id}")]
        public async Task <ActionResult<LibreriaMaterialDto>> GetLibros( Guid id)
        {
              return await _mediator.Send(new  ConsultaFiltro.LibreriaFiltro{LibreriaMateriaGuid=id});
        }
       
    }
}
