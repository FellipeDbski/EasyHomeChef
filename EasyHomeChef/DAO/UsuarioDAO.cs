using EasyHomeChef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyHomeChef.DAO
{
    public class UsuarioDAO
    {
        public void Adiciona(Usuario usuario)
        {
            using (var context = new EasyHomeChefContext())
            {
                context.Add(usuario);
                context.SaveChanges();
            }
        }

        public void Atualiza(Usuario usuario)
        {
            using (var context = new EasyHomeChefContext())
            {
                context.Update(usuario);
                context.SaveChanges();
            }
        }
    }
}