using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyHomeChef.Models
{
    public class Ingrediente
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public Categoria Categoria { get; set; }

        public TipoUnidade UN { get; set; }

        public double MediaPreco { get; set; }

    }
}