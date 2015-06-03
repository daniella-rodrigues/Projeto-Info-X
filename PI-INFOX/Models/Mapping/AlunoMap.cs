using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using PI_INFOX.Models.Basicas;


namespace PI_INFOX.Models.Mapping
{
    public class AlunoMap : EntityTypeConfiguration<basAluno>
    {
        public AlunoMap()
        {
            // Primary Key
            this.HasKey(t => t.matriculaAlunoID);

            // Properties
            this.Property(t => t.matriculaAlunoID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nomeAluno)
                .IsRequired()
                .HasMaxLength(255);

            
            

            // Table & Column Mappings
            this.ToTable("Aluno");
            this.Property(t => t.matriculaAlunoID).HasColumnName("matriculaAluno");
            this.Property(t => t.nomeAluno).HasColumnName("nomeAluno");
            this.Property(t => t.matriculaInstituicaoID).HasColumnName("matriculainstituicao");
            this.Property(t => t.DisciplinaID).HasColumnName("idDisciplina");
            
            // Relacionamento
            //this.HasOptional(t => t.Instituicao)
            //    .WithMany(t => t.Alunos)
            //    .HasForeignKey(d => d.matriculaInstituicaoID);
          
        }

    }
}