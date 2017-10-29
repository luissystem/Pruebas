using Sem10.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sem10.Web.Controllers
{
    public class AutoController : Controller
    {
        private IAutoService service;
        public AutoController(IAutoService service)
        {
            this.service = service;
        }
        [HttpGet]
        public ActionResult Index(String Marca, String Color, Int32? Anio, String Estado, double? PrecioMinimo, double? PrecioMaximo)
        {
            var auto = service.getAuto(Marca, Color, Anio, Estado, PrecioMinimo, PrecioMaximo);
            
           
            
           // ViewBag.a= new SelectList(au, "Id", "Marca");
            return View(auto);
        }
        
    }
}