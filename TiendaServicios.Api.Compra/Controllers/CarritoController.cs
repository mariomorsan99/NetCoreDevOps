using System.ComponentModel;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using TiendaServicios.Api.Compra.Aplicacion;
using TiendaServicios.Api.Compra.Modelo;


namespace TiendaServicios.Api.Compra.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarritoController : ControllerBase
    {

      private readonly IMediator _mediator;

      public CarritoController(IMediator mediator)
      {
          _mediator=mediator;
      }

      [HttpPost]
      public async Task <ActionResult<Unit>> Crear( Nuevo.Ejecuta data)
      {
          return await _mediator.Send(data);
      }
    }
}
