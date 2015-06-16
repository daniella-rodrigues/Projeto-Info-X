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
        [Display(Name = "Numero da Vaga")]
        public int VagaID { get; set; }
        [Display(Name = "Nome da Vaga")]
        public string nomeVaga { get; set; }
        [Display(Name = "Cargo Disponivel")]
        public string cargo { get; set; }
        [Display(Name = "Hora de Entrada")]
        [DisplayFormat(DataFormatString = "{0:hh:mm:ss}")]
        public DateTime horarioEntrada { get; set; }
        [Display(Name = "Hora de Saida")]
        [DisplayFormat(DataFormatString = "{0:hh:mm:ss}")]
        public DateTime horarioSaida { get; set; }
        [Display(Name = "Salario ")]
        public int salario { get; set; }
        [Display(Name = "Nome da Empresa Contratante")]
        public string nomeEmpresa { get; set; }

        //FK
        public int matriculaInstituicaoID { get; set; }

        public virtual basInstituicao Instituicao { get; set; }


    }
}