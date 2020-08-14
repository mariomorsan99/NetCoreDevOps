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

namespace TiendaServicios.Api.Compra.Modelo
{
    public class CarritoSessionDetalle
    {
         public int CarritoSessionDetalleId{ get; set;}

         public DateTime? FechaCreacion{ get; set;}

         public string ProductoSeleccionado{ get; set;}

         public int CarritoSessionId{ get; set;}

         public CarritoSession CarritoSession{ get; set;}
    }
}
