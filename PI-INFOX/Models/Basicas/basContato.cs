using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI_INFOX.Models.Basicas
{
    public class basContato
    {   
        public int ContatoID {get;set;}
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Observacao { get; set; }

    }
}