using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyHomeChef.Models
{
    public class GeladeiraTempero
    {
        public Geladeira Geladeira { get; set; }

        public int GeladeiraID { get; set; }

        public Tempero Tempero { get; set; }

        public int TemperoID { get; set; }
    }
}