using EasyHomeChef.DAO;
using EasyHomeChef.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyHomeChef.Controllers
{
    public class ImagemController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TratamentoImagem(Imagem modeloImagem)
        {
            //Define nomes, extensões e local de armazenamento dos arquivos.
            string nomeArquivo = Path.GetFileNameWithoutExtension(modeloImagem.ImageFile.FileName);
            string extension = Path.GetExtension(modeloImagem.ImageFile.FileName);
            nomeArquivo = nomeArquivo += DateTime.Now.ToString("yymmssfff") + extension; 
            modeloImagem.ImagePath = "~/App_Data/Imagem" + nomeArquivo;
            nomeArquivo = Path.Combine(Server.MapPath("~/App_Data/Imagem"), nomeArquivo);
            modeloImagem.ImageFile.SaveAs(nomeArquivo);

            //Persiste no banco de dados com DAO "~/DAO/ImagemDAO"
            ImagemDAO dao = new ImagemDAO();
            dao.Adiciona(modeloImagem);

            return View();
        }

    }
}