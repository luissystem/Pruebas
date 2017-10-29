using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem10.Entitities.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public double Precio { get; set; }

        public int CategoriaId { get; set; }
    }
}
