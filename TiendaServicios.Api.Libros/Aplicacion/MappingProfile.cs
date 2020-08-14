using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TiendaServicios.Api.Libros.Modelo;

namespace TiendaServicios.Api.Libros.Aplicacion
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<LibreriaMateria,LibreriaMaterialDto>(); 
        }

    }
}
