using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using PI_INFOX.Models.Basicas;

namespace PI_INFOX.Models.Mapping
{
    public class ForumMap : EntityTypeConfiguration<basForum>
    {
        public ForumMap()
        {
            // Primary Key
            this.HasKey(t => t.ForumID);

            // Properties
            this.Property(t => t.ForumID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.titulo)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.mensagem)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("MensagemForum");
            this.Property(t => t.ForumID).HasColumnName("idForum");
            this.Property(t => t.titulo).HasColumnName("titulo");
            this.Property(t => t.dataHoraCriacao).HasColumnName("horaCriacao");
            this.Property(t => t.mensagem).HasColumnName("mensagem");
            this.Property(t => t.DisciplinaID).HasColumnName("idDisciplina");
            this.Property(t => t.matricula).HasColumnName("matricula");

            // Relationships
            //this.HasOptional(t => t.Disciplina)
            //    .WithMany(t => t.MensagemForums)
            //    .HasForeignKey(d => d.DisciplinaID);
         
        }
    }
}