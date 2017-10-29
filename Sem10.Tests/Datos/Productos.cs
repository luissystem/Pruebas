using Moq;
using Sem10.Entitities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem10.Tests.Datos
{
    public static class Productos
    {
        public static IDbSet<Producto> GetDbSet()
        {
            var mockDbSet = new Mock<IDbSet<Producto>>();
            var data = Get();

            mockDbSet.Setup(m => m.Provider).Returns(data.Provider);
            mockDbSet.Setup(m => m.Expression).Returns(data.Expression);
            mockDbSet.Setup(m => m.ElementType).Returns(data.ElementType);
            mockDbSet.Setup(o => o.GetEnumerator()).Returns(data.GetEnumerator());

            return mockDbSet.Object;
        }
        private static IQueryable<Producto> Get()
        { 
            return new List<Producto> {
                new Producto { Id= 1, Codigo = "001", Nombre = "Arroz", Precio = 2.5},
                new Producto { Id= 2, Codigo = "002", Nombre = "Pan", Precio = 0.1},
                new Producto { Id= 3, Codigo = "003", Nombre = "Huevo", Precio = 0.4},
                new Producto { Id= 4, Codigo = "004", Nombre = "Fideos", Precio = 4.6},
                new Producto { Id= 5, Codigo = "005", Nombre = "Pollo", Precio = 8.6},
                new Producto { Id= 6, Codigo = "006", Nombre = "Leche", Precio = 3.2},
                new Producto { Id= 7, Codigo = "007", Nombre = "Atún", Precio = 2.5},
                new Producto { Id= 8, Codigo = "008", Nombre = "Aceite", Precio = 7.2},
                new Producto { Id= 9, Codigo = "009", Nombre = "Hotdog", Precio = 1.0},
                new Producto { Id= 10, Codigo = "010", Nombre = "Queso", Precio = 15.0},
            }.AsQueryable();
        }
    }
}
