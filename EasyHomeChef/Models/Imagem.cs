using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyHomeChef.Models
{
    public class Imagem
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Descriao { get; set; }

        public byte[] Foto { get; set; }

        public long Tamanho { get; set; }
    }
}