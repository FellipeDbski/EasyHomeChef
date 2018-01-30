using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyHomeChef.Models
{
    public class ReceitaTempero
    {
        public Receita Receita { get; set; }

        public int ReceitaID { get; set; }
        
        public Tempero Tempero { get; set; }

        public int TemperoID { get; set; }
    }
}