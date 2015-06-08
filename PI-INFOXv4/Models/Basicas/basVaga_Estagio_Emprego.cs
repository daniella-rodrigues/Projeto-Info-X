using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PI_INFOX.Models.Basicas
{
    public class basVaga_Estagio_Emprego
    {
        //PK
        public int VagaID { get; set; }
        
        public string nomeVaga { get; set; }
        public string cargo { get; set; }
        [DisplayFormat(DataFormatString = "{0:hh:mm:ss}")]
        public DateTime horarioEntrada { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh:mm:ss}")]
        public DateTime horarioSaida { get; set; }

        public int salario { get; set; }
        public string nomeEmpresa { get; set; }

        //FK
        public int matriculaInstituicaoID { get; set; }

        public virtual basInstituicao Instituicao { get; set; }


    }
}