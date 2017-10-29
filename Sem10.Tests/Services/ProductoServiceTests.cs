using Moq;
using NUnit.Framework;
using Sem10.Entitities.Models;
using Sem10.Repositories.Configurations;
using Sem10.Services.Servicios;
using Sem10.Tests.Datos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem10.Tests.Services
{
    [TestFixture]
    public class ProductoServiceTests
    {
        [Test]
        public void PruebaConsultaMenorAPrecio() {           

            var mockDb = new Mock<DbEntities>();
            mockDb.Setup(o => o.Productos).Returns(Productos.GetDbSet());

            var service = new ProductoService(mockDb.Object);

            var result = service.ObtenerTodosMenorAPrecio(5.0);

            Assert.AreEqual(7, result.Count);
        
        }
        [Test]
        public void PruebaConsultaPreciomayorADos()
        {

            var mockDb = new Mock<DbEntities>();
            mockDb.Setup(o => o.Productos).Returns(Productos.GetDbSet());

            var service = new ProductoService(mockDb.Object);

            var result = service.Obtenermayorados(2.0, "A");

            Assert.AreEqual(3, result.Count);

        }
    }
}
