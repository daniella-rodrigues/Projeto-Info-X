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

        [Display(Name = "Titulo do Aviso")]
        public string titulo { get; set; }

        [Display(Name = "Messagem do Aviso")]
        public string messagemAviso { get; set; }
        [Display(Name = "Criado em,  as ")]
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        //fk
        public int DisciplinaID { get; set; }
        
        public virtual basDisciplina Disciplinas { get; set; }
    }
}