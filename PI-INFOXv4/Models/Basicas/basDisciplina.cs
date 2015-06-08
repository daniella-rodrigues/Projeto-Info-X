using System;
using System.Collections.Generic;
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
        public int DisciplinaID { get; set; }
        
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
