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
    public class CarritoSession
    {
         public int CarritoSessionId{ get; set;}

         public DateTime? FechaCreacion{ get; set;}

         public ICollection<CarritoSessionDetalle> ListaDetalle{ get; set;}

         
    }
}
