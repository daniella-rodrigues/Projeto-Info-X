using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PI_INFOX.Models.Basicas
{
    public class basUsuario
    {
        //pk
        public int UserID { get; set; }

        [RegularExpression(@"[a-zA-Z0-9]{5,15}", ErrorMessage = "O login tem q ser  Alfanumerico e entre 5 a 15 caracteres.")]
        public string login { get; set; }

        public string senha { get; set; }
        //[System.ComponentModel.DataAnnotations.Compare("senha", ErrorMessage = " As senhas não conferem")]
        //public string confirmaSenha { get; set; }
        public string lembreteSenha { get; set; }
        public string respostaSenha { get; set; }

        public string email { get; set; }
        //[System.ComponentModel.DataAnnotations.Compare("email", ErrorMessage = " O email são conferem")]
        //public string confirmaEmail { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime dataNascimento { get; set; }

        public string telefone { get; set; }
        public string tipoUser { get; set; }
        public string matricula { get; set; }
        public string nome { get; set; }

     
        //FK

        public int DisciplinaID { get; set; }


        //Relacionamentos
        public virtual basDisciplina Disciplinas { get; set; }
      

    }
}