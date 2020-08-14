using System.Reflection.Metadata;
using System.Threading;
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
using TiendaServicios.Api.Compra.Persistencia;
using TiendaServicios.Api.Compra.Modelo;
using MediatR;

namespace TiendaServicios.Api.Compra.Aplicacion
{
    public class Nuevo
    {
        public class Ejecuta :IRequest{
            public DateTime FechaCreacionSession{ get; set;}

            public List<string> ProductoLista{ get; set;}


        }

        public class Manejador:IRequestHandler<Ejecuta> 
        {
            private readonly CarritoContexto _contexto;

            public Manejador(CarritoContexto contexto)
            {
                _contexto=contexto;
            }


            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var carritoSession= new CarritoSession{
                     FechaCreacion=request.FechaCreacionSession

                };

                _contexto.CarritoSession.Add(carritoSession);
               var value = await _contexto.SaveChangesAsync();
               if(value==0)
               {
                   throw new Exception("errores en la insercion del carrito");
               }

               int id=carritoSession.CarritoSessionId;

               foreach (var item in request.ProductoLista)
               {
                   var detalleSesion= new CarritoSessionDetalle{
                        FechaCreacion= DateTime.Now,
                        CarritoSessionId=id,
                        ProductoSeleccionado= item
                   };

                   _contexto.CarritoSessionDetalle.Add(detalleSesion);
                   
               }

                value= await _contexto.SaveChangesAsync();

                if(value>0){
                    return Unit.Value;
                }

                throw new  Exception("No se pudo insertar el detalle");

            }
        }

        

         
    }
}
