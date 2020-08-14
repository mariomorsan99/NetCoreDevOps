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
using Microsoft.EntityFrameworkCore;
using TiendaServicios.Api.Compra.Modelo;

namespace TiendaServicios.Api.Compra.Persistencia
{
    public class CarritoContexto: DbContext
    {
         
      public CarritoContexto(DbContextOptions<CarritoContexto> options): base(options){}

      public DbSet<CarritoSession> CarritoSession{ get; set;}

      public DbSet<CarritoSessionDetalle> CarritoSessionDetalle{ get; set;}

         
    }
}
