using ExamenU2Web2_Lizarraga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenU2Web2_Lizarraga.Controllers
{
    public class Ejercicio2Controller : Controller
    {

        private Operacion operacion = new Operacion();
        private TipoOperacion tipooperacion = new TipoOperacion();


        // GET: Ejercicio2
        public ActionResult Index()
        {
            return View(operacion.Listar());
        }
    }
}