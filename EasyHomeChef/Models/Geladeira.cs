using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyHomeChef.Models
{
    public class Geladeira
    {
        public int ID { get; set; }

        public IList<Ingrediente> Ingrediente { get; set; }

        public IList<Tempero> Tempero { get; set; }

    }
}