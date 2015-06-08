using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PI_INFOX.Models.Basicas
{
    public class basForum
    {
        //PK
        public int ForumID { get; set; }
        
        public string titulo { get; set; }

       
        public DateTime dataHoraCriacao { get; set; }
        public string mensagem { get; set; }
        public string mensagemResposta { get; set; }

        //FK
        public int DisciplinaID { get; set; }
        public int matricula { get; set; }
    
        
        //Relacionamentos
        public virtual basUsuario Usuarios { get; set; }
        public virtual basDisciplina Disciplina { get; set; }
     
        
    }
}
