using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EXPRACU1_Lizarraga.Models;

namespace EXPRACU1_Lizarraga.Controllers
{
    public class Ejercicio3Controller : Controller
    {
        // GET: Ejercicio3
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IngresarNumeros(ClsListas objListas)
        {
            if (Request.Form["cantidad"] != null)
            {
                objListas.cantidad = Convert.ToInt32(Request.Form["cantidad"].ToString());
            }

            return View(objListas);
        }

        public ActionResult VerResultados(ClsListas objListas)
        {
            //string paolo = Request.Form["cantidad"].ToString();
            objListas.lista1 = new List<double>();
            objListas.lista2 = new List<double>();
            objListas.listarepetidos = new List<double>();

            if (Request.Form["cantidad"] != null)
            {
                objListas.cantidad = Convert.ToInt32(Request.Form["cantidad"].ToString());

                for (int i = 0; i < objListas.cantidad; i++)
                {
                    if (Convert.ToDouble(Request.Form["a" + i.ToString()]) != 0)
                    {
                        objListas.lista1.Add(Convert.ToDouble(Request.Form["a" + i.ToString()]));
                    }

                    if (Convert.ToDouble(Request.Form["b" + i.ToString()]) != 0)
                    {
                        objListas.lista2.Add(Convert.ToDouble(Request.Form["b" + i.ToString()]));
                    }
                }                

                for (int i = 0; i < objListas.lista1.Count; i++)
                {
                    int repetidos = 0;
                    for (int y = 0; y < objListas.lista2.Count; y++)
                    {
                        if (objListas.lista1[i] == objListas.lista2[y])
                        {
                            repetidos++;
                        }
                        if (y == (objListas.lista2.Count - 1))
                        {
                            objListas.listarepetidos.Add(repetidos);
                        }
                    }
                }
            }
            return View(objListas);
        }
    }
}