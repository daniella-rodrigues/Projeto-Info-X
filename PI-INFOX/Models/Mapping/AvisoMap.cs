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

            this.Property(t => t.titulo)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.messagemAviso)
               .IsRequired()
               .HasMaxLength(255);

            

            // Table & Column Mappings
            this.ToTable("Aviso");
            this.Property(t => t.AvisoID).HasColumnName("idAviso");
            this.Property(t => t.titulo).HasColumnName("titulo");
            this.Property(t => t.messagemAviso).HasColumnName("messagemAviso");
            this.Property(t => t.DataCadastro).HasColumnName("dataPublicacao");
            this.Property(t => t.DisciplinaID).HasColumnName("idDisciplina");
           
           

        }
    }
}