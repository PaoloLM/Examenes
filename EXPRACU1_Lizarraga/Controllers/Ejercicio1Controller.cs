using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EXPRACU1_Lizarraga.Models;

namespace EXPRACU1_Lizarraga.Controllers
{
    public class Ejercicio1Controller : Controller
    {
        // GET: Ejercicio1
        public ActionResult Index(ClsLitro objLitro)
        {
            int montofijo = 40;
            int aux1 = 0;
            int aux2 = 0;
            int aux3 = 0;

            string paolo = Request["cantidad"];

            if (paolo != null)
            {
                objLitro.litro = Int32.Parse(Request["cantidad"].ToString());

                if (objLitro.litro <= 49)
                {
                    objLitro.total = montofijo;
                }

                else
                {
                    if (objLitro.litro >= 50 && objLitro.litro <= 200)
                    {
                        aux1 = objLitro.litro - 49;
                        objLitro.total = aux1 + montofijo;
                    }
                    else if (objLitro.litro >= 201)
                    {
                        aux1 = objLitro.litro - 49;
                        aux2 = aux1 - 151;
                        aux3 = aux2 * 2;
                        objLitro.total = montofijo + aux3 + 151;
                    }
                }
            }

            return View(objLitro);
        }
    }
}