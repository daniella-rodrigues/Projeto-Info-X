using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI_INFOX.Models.Basicas
{
    public class basUsuario
    {
        //pk
        public int UserID { get; set; }

        public string login { get; set; }
        public string senha { get; set; }
        public string confirmaSenha { get; set; }
        public string lembreteSenha { get; set; }
        public string respostaSenha { get; set; }
        public string email { get; set; }
        public string confirmaEmail { get; set; }
        public DateTime dataNascimento { get; set; }
        public string telefone { get; set; }
        public string tipoUser { get; set; }

        //Relacionamento
         public string matricula { get; set; }
        public string nome { get; set; }
        public string Instituicao { get; set; }

    }
}