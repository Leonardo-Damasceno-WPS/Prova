using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prova.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string cep { get; set; }
        public byte[] foto { get; set; }
        public int status { get; set; }
    }
}