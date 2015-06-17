using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PI_INFOX.Models.Basicas
{
    public class basDisciplina
    {
             public basDisciplina()
        {
            this.Materiais = new List<basMaterial>();
            this.MensagemForums = new List<basForum>();
            this.Professores = new List<basProfessor>();
            this.Alunos = new List<basAluno>();
            this.Avisos = new List<basAviso>();
            this.Usuarios = new List<basUsuario>();
        }

        //PK
        [Display(Name = "Numero da Disciplina")]
        public int DisciplinaID { get; set; }

        [Display(Name = "Nome da Disciplina")]
        public string nomeDisciplina { get; set; }
       
      

        //Relacionamentos
        public virtual ICollection<basMaterial> Materiais { get; set; }
        public virtual ICollection<basForum> MensagemForums { get; set; }
        public virtual ICollection<basProfessor> Professores { get; set; }
        public virtual ICollection<basAluno> Alunos { get; set; }
        public virtual ICollection<basAviso> Avisos { get; set; }
        public virtual ICollection<basUsuario> Usuarios { get; set; }
    }
}
