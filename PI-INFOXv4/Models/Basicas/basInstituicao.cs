using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI_INFOX.Models.Basicas
{
    public class basInstituicao
    {
            public basInstituicao()
        {
            this.Alunos = new List<basAluno>();
            this.Professores = new List<basProfessor>();
            this.Usuarios = new List<basUsuario>();
        }

        //PK
        public int matriculaInstituicaoID { get; set; }

        public string login { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }

        //Relacionamentos
        //public virtual basVaga_Estagio_Emprego Vagas { get; set; }
        public virtual ICollection<basAluno> Alunos { get; set; }
        public virtual ICollection<basProfessor> Professores { get; set; }
        public virtual ICollection<basUsuario> Usuarios { get; set; }


    }
}