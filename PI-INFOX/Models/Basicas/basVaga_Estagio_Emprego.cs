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
        [Display(Name = "N° da Vaga")]
        public int VagaID { get; set; }

        [Display(Name = "Nome da Vaga")]
        public string nomeVaga { get; set; }

        [Display(Name = "Tipo da Vaga")]
        public string tipoVaga { get; set; }

        [Display(Name = "Cargo")]
        public string cargo { get; set; }
     
        [Display(Name = "Pre-Requesitos")]
        public string requesito { get; set; }

        [Display(Name = "Experiencia Necessária")]
        public string exp { get; set; }

        [Display(Name = "Formação Necessária")]
        public string formacao { get; set; }
        
        [Display(Name = "Local da Vaga")]
        public string local { get; set; }

        [Display(Name = "Horário")]
        public string horario { get; set; }

            
        [Display(Name = "Salario ")]
        public int salario { get; set; }

        [Display(Name = "Nome da Empresa Contratante")]
        public string nomeEmpresa { get; set; }
        [Display(Name = "Criado em,  as ")]
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        ////FK
        //[Display(Name = "Empresa Fornecedora")]
        //public int matriculaInstituicaoID { get; set; }

        //public virtual basInstituicao Instituicao { get; set; }


    }
}