using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI_INFOX.Models.Basicas
{
    public class basAluno
    {
        //public basAluno()
        //{
        //    this.Disciplinas = new List<basDisciplina>();
            
            
        //}

        //PK
        public int matriculaAlunoID { get; set; }
             
        public string nomeAluno { get; set; }
        
        
        //FK
        public int matriculaInstituicaoID { get; set; }
        public int DisciplinaID { get; set; }
        
        
        //Relacionamentos
                      
        public virtual basInstituicao Instituicao { get; set; }
        public virtual basDisciplina Disciplinas { get; set; }
    }
}