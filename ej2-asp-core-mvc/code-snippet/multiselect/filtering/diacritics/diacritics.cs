using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MultiSelectController : Controller
    {
        public ActionResult diacritics()
        {
            ViewBag.data = new string[] { "Aeróbics", "Aeróbics en Agua", "Aerografía", "Aeromodelaje", "Águilas", "Ajedrez", "Ala Delta", "Álbumes de Música","Alusivos", "Análisis de Escritura a Mano"  };
            return View();
        }       
    }
}