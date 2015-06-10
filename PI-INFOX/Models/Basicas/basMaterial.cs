using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PI_INFOX.Models.Basicas
{
   public class basMaterial
    {
        //PK
       [Display(Name = "Numero do Post")]
        public int MaterialID { get; set; }

        public string Descricao { get; set; }
        [Display(Name = "Arquivo Disponivel em:")]
        public string linkDiretorio { get; set; }

        //FK
        public int DisciplinaID { get; set; }
        public int matricula { get; set; }

        ////Relacionametnos
        public virtual basDisciplina Disciplinas { get; set; }
        public virtual basUsuario Usuarios { get; set; }
    }
}
