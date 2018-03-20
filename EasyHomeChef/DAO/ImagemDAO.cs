using EasyHomeChef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyHomeChef.DAO
{
    public class ImagemDAO
    {

        public void Adiciona(Imagem imagem)
        {
            using (var context = new EasyHomeChefContext())
            {
                context.Add(imagem);
                context.SaveChanges();
            }
        }

    }
}