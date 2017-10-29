using Sem10.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sem10.Entitities.Models;
using Sem10.Repositories.Configurations;
using System.Data.Entity;

namespace Sem10.Services.Servicios
{
    public class AutoService : IAutoService
    {
        private DbEntities entities;
        public AutoService(DbEntities entities)
        {
            this.entities = entities;
        }

        public IEnumerable<Auto> getAuto()
        {
            return entities.Autos.ToList();
        }

        public IEnumerable<Auto> getAuto(String Marca, String Color, int? Anio, String Estado, double? PrecioMinimo, double? PrecioMaximo)
        {
            var query = from p in entities.Autos
                        select p;
            if (!string.IsNullOrEmpty(Marca))
            {
                query = from p in query
                        where p.Marca.ToUpper().Equals(Marca.ToUpper())

                        select p;

              
            }
            if (!string.IsNullOrEmpty(Color))
            {
                query = from p in query
                        where p.Color.ToUpper().Equals(Color.ToUpper())

                        select p;
                
            }
            if (Anio.HasValue)
            {
                query = from p in query
                        where p.Año == Anio

                        select p;

            }
            if (!string.IsNullOrEmpty(Estado))
            {
                query = from p in query
                        where p.Estado.ToUpper().Equals(Estado.ToUpper())

                        select p;

            }
            if (PrecioMinimo.HasValue&&PrecioMaximo.HasValue)
            {

                return entities.Autos.Where(o => o.Precio >= PrecioMinimo).Where(o => o.Precio <= PrecioMaximo).ToList();


            }
            if (PrecioMinimo.HasValue )
            {

                return entities.Autos.Where(o => o.Precio >= PrecioMinimo).ToList();


            }
            if ( PrecioMaximo.HasValue)
            {

                return entities.Autos.Where(o => o.Precio <= PrecioMaximo).ToList();


            }
            if (!string.IsNullOrEmpty(Color) && !string.IsNullOrEmpty(Marca) && Anio.HasValue&&!string.IsNullOrEmpty(Estado)&&PrecioMinimo.HasValue)
            {


                return entities.Autos.Where(o => o.Color == Color).Where(o => o.Marca == Marca).Where(o => o.Año == Anio).Where(o => o.Precio==PrecioMinimo).ToList();
            }
            //if (!string.IsNullOrEmpty(Color)&& !string.IsNullOrEmpty(Marca))
            //{


            //    return entities.Autos.Where(o => o.Color== Color).Where(o => o.Marca== Marca).ToList();
            //}

            return query;
        }
    }
}
