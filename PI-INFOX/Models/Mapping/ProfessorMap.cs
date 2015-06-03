using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using PI_INFOX.Models.Basicas;

namespace PI_INFOX.Models.Mapping
{
    public class ProfessorMap : EntityTypeConfiguration<basProfessor>
    {
        public ProfessorMap()
        {
            // Primary Key
            this.HasKey(t => t.matriculaID);

            // Properties
            this.Property(t => t.matriculaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.disciplinaExtras)
                .IsRequired()
                .HasMaxLength(255);
                       
            this.Property(t => t.nome)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Professor");
            this.Property(t => t.matriculaID).HasColumnName("matricula");
            this.Property(t => t.disciplinaExtras).HasColumnName("disciplinaExtras");
           this.Property(t => t.nome).HasColumnName("nome");
           this.Property(t => t.matriculaInstituicaoID).HasColumnName("idmatriculainstituicao");
            this.Property(t => t.DisciplinaID).HasColumnName("idDisciplina");

            // Relationships
               //this.HasOptional(t => t.Disciplinas)
               // .WithMany(t => t.Professores)
               // .HasForeignKey(d => d.DisciplinaID);
            
        }
    }
}