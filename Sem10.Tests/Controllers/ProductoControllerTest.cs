using Moq;
using NUnit.Framework;
using Sem10.Entitities.Models;
using Sem10.Interfaces.Services;
using Sem10.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Sem10.Tests.Controllers
{
    [TestFixture]
    public class ProductoControllerTest
    {
        [Test]
        public void ProbarQueNoGuardeSiNoCumpleValidacion()
        {
            var mock = new Mock<IProductoService>();
            var controller = new ProductoController(mock.Object);

            var resultado = controller.Guardar(new Producto { });

            Assert.IsInstanceOf<ViewResult>(resultado);
            Assert.IsNotInstanceOf<RedirectToRouteResult>(resultado);
        }

        [Test]
        public void ProbarQueGuardaSiCumpleValidacion()
        {
            var mock = new Mock<IProductoService>();
            var controller = new ProductoController(mock.Object);

            var resultado = controller.Guardar(new Producto { 
                Codigo = "005",
                Nombre = "Arroz",
                Precio = 2.3,
                CategoriaId = 1            
            });

            Assert.IsInstanceOf<RedirectToRouteResult>(resultado);
            Assert.IsNotInstanceOf<ViewResult>(resultado);
        }

    }
}
