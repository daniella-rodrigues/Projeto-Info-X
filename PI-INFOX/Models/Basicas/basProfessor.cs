using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI_INFOX.Models.Basicas
{
   public class basProfessor
    {
       
        //PK
        public int matriculaID { get; set; }

        public string nome { get; set; }
        public string disciplinaExtras { get; set; }
        //FK
        public int matriculaInstituicaoID { get; set; }
        public int DisciplinaID { get; set; }

        //Relacionamentos
        public virtual basDisciplina Disciplinas { get; set; }
        public virtual basInstituicao Instituicao { get; set; }
    }
}
