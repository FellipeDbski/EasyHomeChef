using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EasyHomeChef.DAO;
using EasyHomeChef.Models;

namespace EasyHomeChef.Controllers
{
    public class UsuariosController : Controller
    {

        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult CriarUsuario(Usuario usuario)
        {
            UsuarioDAO user = new UsuarioDAO();
            user.Adiciona(usuario);

            GeladeiraDAO geladeiraDAO = new GeladeiraDAO();
            Geladeira geladeira = new Geladeira();

            usuario.GeladeiraID = geladeira.ID;

            user.Atualiza(usuario);
          
            return RedirectToAction("Index");
        }

    }
}
