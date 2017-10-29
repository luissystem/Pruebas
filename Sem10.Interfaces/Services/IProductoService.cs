using Sem10.Entitities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem10.Interfaces.Services
{
    public interface IProductoService
    {
        List<Producto> ObtenerTodos();

        List<Producto> ObtenerTodosMenorAPrecio(double precio);
        List<Producto> Obtenermayorados(double precio, string letra);
        void Guardar(Producto producto);
    }
}
