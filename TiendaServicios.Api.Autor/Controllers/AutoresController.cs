using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using TiendaServicios.Api.Autor.Aplicacion;

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
    }
}
