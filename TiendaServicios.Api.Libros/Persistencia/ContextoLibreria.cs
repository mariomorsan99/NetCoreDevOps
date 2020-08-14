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
using Microsoft.EntityFrameworkCore.Design;
using TiendaServicios.Api.Libros.Modelo;


namespace TiendaServicios.Api.Libros.Persistencia
{
    public class ContextoLibreria : DbContext
    {
        
       public ContextoLibreria(DbContextOptions<ContextoLibreria> options): base(options){}


       public DbSet<LibreriaMateria> LibreriaMaterial{ get; set;}
    }
}
