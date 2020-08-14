using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using TiendaServicios.Api.Autor.Aplicacion;
using TiendaServicios.Api.Autor.Modelo;


namespace TiendaServicios.Api.Autor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutoresController : ControllerBase
    {
         private readonly IMediator _mediator;
        
         public AutoresController(IMediator mediator)
        {
            _mediator=mediator;
        }

        [HttpPost]
        public async Task <ActionResult<Unit>> Crear(Nuevo.Ejecuta data) 
        {
              return await _mediator.Send(data);
        }

        [HttpGet]
        public async Task <ActionResult<List<AutorLibro>>> GetAutores()
        {
              return await _mediator.Send(new Consulta.ListaAutor());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AutorLibro>> GetAutorLibro(string id)
        {
            return await _mediator.Send( new ConsultaFiltro.AutorUnico{AutorGuid=id});
        }
    }
}
