using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyHomeChef.Models
{
    public class Receita
    {
        public int ID { get; set; }

        public string Nome { get; set; }
        
        public NivelReceita Dificuldade { get; set; }

        public IList<Ingrediente> Ingredientes { get; set; }

        public string ModoPreparo { get; set; }

        public int TempoPreparo { get; set; }
    }
}