using ExamenU2Web2_Lizarraga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenU2Web2_Lizarraga.Controllers
{
    public class Ejercicio1Controller : Controller
    {
        private Operacion operacion = new Operacion();
        private TipoOperacion tipooperacion = new TipoOperacion();

        // GET: Ejercicio1
        public ActionResult Index(string criterio, string busqueda)
        {
            if (criterio == null  || criterio == "" || busqueda == null || busqueda == "")
            {
                return View(operacion.Listar());
            }
            else
            {
                if (busqueda.Equals("T"))
                {
                    return View(operacion.BuscarTipo(criterio));
                }
                else
                {
                    return View(operacion.BuscarFecha(criterio));
                }

            }
        }

        public ActionResult AgregarModificar(int id = 0)
        {
            //Tipo Usuario
            ViewBag.Tipo = tipooperacion.Listar();

            return View(id == 0 ? new Operacion()
                                : operacion.Obtener(id));
        }


        public ActionResult Guardar(Operacion model)
        {
            if (ModelState.IsValid)
            {
                model.Guardar();
                return Redirect("~/Ejercicio1");
            }
            else
            {
                return View("~/Views/Ejercicio1/AgregarModificar.cshtml", model);
            }
        }

        public ActionResult Eliminar(int id)
        {
            operacion.operacion_id = id;
            operacion.Eliminar();
            return Redirect("~/Ejercicio1");
        }
    }
}