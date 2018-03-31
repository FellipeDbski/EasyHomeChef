using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyHomeChef.Models
{
    public class GeladeiraIngrediente
    {
        public Geladeira Geladeira { get; set; }

        public int? GeladeiraID { get; set; }

        public Ingrediente Ingrediente { get; set; }

        public int? IngredienteID { get; set; }

        public int Quantidade { get; set; }
    }
}