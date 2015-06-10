using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using PI_INFOX.Models.Basicas;


namespace PI_INFOX.Models.Mapping 
{
    public class AvisoMap : EntityTypeConfiguration<basAviso>
    {

        public AvisoMap()
        {
            // PK
            this.HasKey(t => t.AvisoID);

            // Properties

            this.Property(t => t.AvisoID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.nomeAviso)
                .IsRequired()
                .HasMaxLength(255);

            

            

            // Table & Column Mappings
            this.ToTable("Aviso");
            this.Property(t => t.AvisoID).HasColumnName("idAviso");
            this.Property(t => t.nomeAviso).HasColumnName("nomeAviso");
            this.Property(t => t.horaPublicacao).HasColumnName("horaPublicacao");
            this.Property(t => t.DisciplinaID).HasColumnName("idDisciplina");
           
           

        }
    }
}