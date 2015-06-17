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
        [Display(Name = "Numero de Cadastro")]
        public int UserID { get; set; }

        [RegularExpression(@"[a-zA-Z0-9]{5,15}", ErrorMessage = "O login tem q ser  Alfanumerico e entre 5 a 15 caracteres.")]
        public string login { get; set; }
        [Display(Name = "Digite a Senha")]
        [DataType(DataType.Password)]
        public string senha { get; set; }
        //[System.ComponentModel.DataAnnotations.Compare("senha", ErrorMessage = " As senhas não conferem")]
        //public string confirmaSenha { get; set; }
        [Display(Name = "Lembrete de Senha")]
        public string lembreteSenha { get; set; }
        [Display(Name = "Resposta")]
        public string respostaSenha { get; set; }
        [Display(Name = "E-Mail")]
        public string email { get; set; }
        //[System.ComponentModel.DataAnnotations.Compare("email", ErrorMessage = " O email são conferem")]
        //public string confirmaEmail { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime dataNascimento { get; set; }

        public string telefone { get; set; }

         [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "O Tipo de Usuario So pode ser em Letras e no formatdo 'ALUNO' OU 'PROFESSOR'.")]
        [Display(Name = "Tipo de Usuario")]
        public string tipoUser { get; set; }
        
        [Display(Name = "Digite Sua Matricula")]
        public string matricula { get; set; }
        [Display(Name = "Digite seu Nome")]
        public string nome { get; set; }

     
        //FK

        
        public int DisciplinaID { get; set; }


        //Relacionamentos
        public virtual basDisciplina Disciplinas { get; set; }
      

    }
}