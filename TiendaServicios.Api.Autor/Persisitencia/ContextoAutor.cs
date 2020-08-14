using System.Collections.Generic;
using System.Dynamic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TiendaServicios.Api.Autor.Modelo;

namespace TiendaServicios.Api.Autor.Persistencia
{
    public class ContextoAutor: DbContext
    {
        public ContextoAutor(DbContextOptions<ContextoAutor> options): base(options){}
        
        public DbSet<AutorLibro> AutorLibro{ get; set;}

        public DbSet <GradoAcademico> GradoAcademico{ get; set;}

    }
}
