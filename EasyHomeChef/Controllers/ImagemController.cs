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
        public ActionResult Upload()
        {
            var file = this.Request.Files[0];
            string savedFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "files");
            savedFileName = Path.Combine(savedFileName, Path.GetFileName(file.FileName));
            file.SaveAs(savedFileName);

            return View();
        }

    }
}