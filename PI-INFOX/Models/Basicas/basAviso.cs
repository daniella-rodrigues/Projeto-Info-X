using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI_INFOX.Models.Basicas
{
    public class basAviso
    {
      
        
        //PK
        public int AvisoID { get; set; }
        
        public string nomeAviso { get; set; }
        public DateTime horaPublicacao { get; set; }

        //fk
        public string DisciplinaID { get; set; }
        
        public virtual basDisciplina Disciplinas { get; set; }
    }
}