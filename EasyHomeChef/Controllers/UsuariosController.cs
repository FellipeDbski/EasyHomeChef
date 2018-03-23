using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

        [HttpPost]
        public ActionResult CriarUsuario(Usuario usuario)
        {
            UsuarioDAO user = new UsuarioDAO();
            user.Adiciona(usuario);

            GeladeiraDAO geladeiraDAO = new GeladeiraDAO();
            Geladeira geladeira = new Geladeira();

            usuario.GeladeiraID = geladeira.ID;

            var arquivo = this.Request.Files[0];

            string arquivoSalvo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "files");
            arquivoSalvo = Path.Combine(arquivoSalvo, Path.GetFileName(arquivo.FileName));
            arquivo.SaveAs(arquivoSalvo);

            usuario.ImagePath = arquivoSalvo;
            user.Atualiza(usuario);
          
            return RedirectToAction("Index");
        }
    }
}
