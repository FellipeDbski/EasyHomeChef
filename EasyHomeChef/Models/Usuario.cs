using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyHomeChef.Models
{
    public class Usuario
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public Geladeira Geladeira { get; set; }

        public int GeladeiraID { get; set; }
    }
}