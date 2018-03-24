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
            //cria uma geladeira e um dao
            GeladeiraDAO geladeiraDAO = new GeladeiraDAO();
            Geladeira geladeira = new Geladeira();

            //persiste a geladeira no banco de dados
            geladeiraDAO.Adiciona(geladeira);

            //salva geladeira em usuario
            usuario.GeladeiraID = geladeira.ID;

            //cria usuário
            UsuarioDAO user = new UsuarioDAO();

            //salva usuario no banco com DAO
            user.Adiciona(usuario);

            //Salva a url da imagem em user_imagepath como uma string
            var arquivo = this.Request.Files[0];
            string arquivoSalvo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "files");
            arquivoSalvo = Path.Combine(arquivoSalvo, Path.GetFileName(arquivo.FileName));
            arquivo.SaveAs(arquivoSalvo);
            usuario.ImagePath = arquivoSalvo;

            //atuliaza o usuario com novas informações.
            user.Atualiza(usuario);
          
            return RedirectToAction("Index", "Home");
        }
    }
}
