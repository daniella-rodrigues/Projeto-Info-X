using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using PI_INFOX.Models.Basicas;

namespace PI_INFOX.Models.Mapping
{
    public class MaterialMap : EntityTypeConfiguration<basMaterial>
    {
        public MaterialMap()
        {
            // Primary Key
            this.HasKey(t => t.MaterialID);

            // Properties
            this.Property(t => t.MaterialID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.linkDiretorio)
                .IsRequired()
                .HasMaxLength(255);

         

            // Table & Column Mappings
            this.ToTable("Material");
            this.Property(t => t.MaterialID).HasColumnName("idMaterial");
            this.Property(t => t.Descricao).HasColumnName("nome");
            this.Property(t => t.linkDiretorio).HasColumnName("linkDiretorio");
            this.Property(t => t.DisciplinaID).HasColumnName("idDisciplina");
            this.Property(t => t.matricula).HasColumnName("matricula");


            // Relationships
            //this.HasOptional(t => t.Disciplinas)
            //    .WithMany(t => t.Materiais)
            //    .HasForeignKey(d => d.DisciplinaID);
            //this.HasOptional(t => t.Alunos)
            //    .WithMany(t => t.Materias)
            //    .HasForeignKey(d => d.matriculaAlunoID);

        }
    }
}