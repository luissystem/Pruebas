using Sem10.Entitities.Models;
using Sem10.Interfaces.Services;
using Sem10.Repositories.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem10.Services.Servicios
{
    public class ProductoService : IProductoService
    {
        private DbEntities entities;
        public ProductoService(DbEntities entities)
        {
            this.entities = entities;
        }

        public List<Producto> ObtenerTodos()
        {
            return entities.Productos.ToList();
        }

        public List<Producto> ObtenerTodosMenorAPrecio(double precio)
        {
            return entities.Productos.Where(o => o.Precio < precio).ToList();
        }
        public List<Producto> Obtenermayorados(double precio, string letra)
        {
            return entities.Productos.Where(o => o.Precio >  precio ).Where(o => o.Nombre.Contains(letra)).ToList();
        }

        public void Guardar(Producto producto)
        {
            entities.Productos.Add(producto);
            entities.SaveChanges();
        }
    }
}
