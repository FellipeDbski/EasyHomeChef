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
        public ActionResult CriarUsuario(Usuario usuario, HttpPostedFileBase arquivo)
        {
            //DAO 
            UsuarioDAO user = new UsuarioDAO();
            GeladeiraDAO geladeiraDAO = new GeladeiraDAO();
            ImagemDAO imagemDao = new ImagemDAO();

            Geladeira geladeira = new Geladeira();
            geladeiraDAO.Adiciona(geladeira);
            usuario.GeladeiraID = geladeira.ID;
           

            //Busca o arquivo do file.upload com o razor e trás para o servidor.
            var post = Request.Files[0];
            var obj = new Imagem();
            var file = new FileInfo(post.FileName);

            obj.Nome = file.Name;
            obj.Descriao = file.Extension;

            //Faz a conversão da imagem para byte e persiste no banco de dados
            using (var reader = new BinaryReader(post.InputStream))
                obj.Foto = reader.ReadBytes(post.ContentLength);

            imagemDao.Adiciona(obj);
            usuario.ImagemID = obj.ID;

            user.Adiciona(usuario);

            return RedirectToAction("Index", "Home");
        }


    }
}
