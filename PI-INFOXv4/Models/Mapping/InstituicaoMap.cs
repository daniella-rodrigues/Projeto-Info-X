using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using PI_INFOX.Models.Basicas;


namespace PI_INFOX.Models.Mapping
{
    public class InstituicaoMap :EntityTypeConfiguration<basInstituicao>
    {
             public InstituicaoMap()
        {
            // Primary Key
            this.HasKey(t => t.matriculaInstituicaoID);

            // Properties
            this.Property(t => t.matriculaInstituicaoID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.senha)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.nome)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Instituicao");
            this.Property(t => t.matriculaInstituicaoID).HasColumnName("matriculainstituicao");
            this.Property(t => t.login).HasColumnName("login");  
            this.Property(t => t.senha).HasColumnName("senha");
            this.Property(t => t.nome).HasColumnName("nome");
            //this.Property(t => t.VagaID).HasColumnName("idVaga");
        
            //Relacionamento


        }
    }
}