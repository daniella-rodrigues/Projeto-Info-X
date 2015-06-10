using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PI_INFOX.Models.Basicas
{
    public class basAviso
    {
      
        
        //PK
        [Display(Name = "Numero Aviso")]
        public int AvisoID { get; set; }

        [Display(Name = "Numero Aviso")]
        public string nomeAviso { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh:mm:ss}")]
        public DateTime horaPublicacao { get; set; }

        //fk
        public int DisciplinaID { get; set; }
        
        public virtual basDisciplina Disciplinas { get; set; }
    }
}