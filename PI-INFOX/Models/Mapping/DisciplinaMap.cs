using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using PI_INFOX.Models.Basicas;

namespace PI_INFOX.Models.Mapping
{
    public class DisciplinaMap : EntityTypeConfiguration<basDisciplina>
    {
        public DisciplinaMap()
        {
            // Primary Key
            this.HasKey(t => t.DisciplinaID);

            // Properties
            this.Property(t => t.DisciplinaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.nomeDisciplina)
                .IsRequired()
                .HasMaxLength(255);

         
            // Table & Column Mappings
            this.ToTable("Disciplina");
            this.Property(t => t.DisciplinaID).HasColumnName("idDisciplina");
            this.Property(t => t.nomeDisciplina).HasColumnName("nomeDisciplina");
          

        }
    }
}