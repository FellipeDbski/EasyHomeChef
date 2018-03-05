using EasyHomeChef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyHomeChef.DAO
{
    public class GeladeiraDAO
    {
        public void Adiciona(Geladeira geladeira)
        {
            using (var context = new EasyHomeChefContext())
            {
                context.Add(geladeira);
                context.SaveChanges();
            }
        }
    }
}