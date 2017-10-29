using Sem10.Entitities.Models;
using Sem10.Interfaces.Services;
using Sem10.Services.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sem10.Web.Controllers
{
    public class ProductoController : Controller
    {
        private IProductoService service;

        public ProductoController(IProductoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var productos = service.ObtenerTodos();
            return View(productos);
        }

        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(Producto producto)
        {
            EjecutarValidacionesDeGuardar(producto);
            if (ModelState.IsValid)
            {
                service.Guardar(producto);
                return RedirectToAction("Index");
            }

            return View("crear", producto);
        }

        private void EjecutarValidacionesDeGuardar(Producto producto)
        {
            if (string.IsNullOrEmpty(producto.Codigo))
                ModelState.AddModelError("Codigo", "Código es obligatorio");

            if (string.IsNullOrEmpty(producto.Nombre))
                ModelState.AddModelError("Nombre", "Nombre es obligatorio");

            if (producto.CategoriaId == 0)
                ModelState.AddModelError("CategoriaId", "Categoría es obligatorio");

            if (producto.Precio <= 0)
                ModelState.AddModelError("Precio", "Precio es obligatorio y debe ser mayor a 0");
        }
	}
}