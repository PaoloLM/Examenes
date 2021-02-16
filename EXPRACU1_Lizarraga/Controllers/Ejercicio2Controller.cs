using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EXPRACU1_Lizarraga.Models;

namespace EXPRACU1_Lizarraga.Controllers
{
    public class Ejercicio2Controller : Controller
    {
        // GET: Ejercicio2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(ClsUsuario objUsuario)
        {
            objUsuario.token = false;
            objUsuario.usuariosLogin = new List<ClsUsuario>();

            ClsUsuario user1 = new ClsUsuario();
            user1.usuario = "paolo";
            user1.contraseña = "paolo";

            ClsUsuario user2 = new ClsUsuario();
            user2.usuario = "admin";
            user2.contraseña = "admin";

            ClsUsuario user3 = new ClsUsuario();
            user3.usuario = "1234";
            user3.contraseña = "1234";

            objUsuario.usuariosLogin.Add(user1);
            objUsuario.usuariosLogin.Add(user2);
            objUsuario.usuariosLogin.Add(user3);

            objUsuario.usuario = Request["usuario"];
            objUsuario.contraseña = Request["contraseña"];

            for (int i = 0; i < objUsuario.usuariosLogin.Count; i++)
            {
                if (objUsuario.usuario == objUsuario.usuariosLogin[i].usuario && objUsuario.contraseña == objUsuario.usuariosLogin[i].contraseña)
                {
                    objUsuario.token = true;
                }
            }


            return View(objUsuario);
        }
    }
}