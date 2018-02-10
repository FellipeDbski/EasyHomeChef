using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EasyHomeChef.Models;

namespace EasyHomeChef.Controllers
{
    public class UsuariosController : Controller
    {

        public ActionResult Cadastro(Usuario usuario, Geladeira geladeira)
        {
           
            return RedirectToAction("Index");
        }

    }
}
