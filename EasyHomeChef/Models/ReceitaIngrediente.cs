using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyHomeChef.Models
{
    public class ReceitaIngrediente
    {
        public Receita Receita { get; set; }

        public int? ReceitaID { get; set; }

        public Ingrediente Ingrediente { get; set; }

        public int? IngredienteID { get; set; }

        public string UnidadeMedida { get; set; }
    }
}