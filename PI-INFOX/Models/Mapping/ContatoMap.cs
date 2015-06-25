using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using PI_INFOX.Models.Basicas;

namespace PI_INFOX.Models.Mapping
{
    public class ContatoMap : EntityTypeConfiguration<basContato> 
    {
        public ContatoMap()
        { 
        
            //pk

            this.HasKey(t => t.ContatoID);

            //propriedades
            this.Property(t => t.ContatoID)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Nome)
              .IsRequired()
              .HasMaxLength(255);

            this.Property(t => t.Email)
              .IsRequired()
              .HasMaxLength(50);

            this.Property(t => t.Telefone)
              .IsOptional()
              .HasMaxLength(25);

            this.Property(t => t.Observacao)
              .IsRequired()
              .HasMaxLength(255);

            //Tabelas e Colunas
            this.ToTable("contato");
            this.Property(t => t.ContatoID).HasColumnName("id");
            this.Property(t => t.Nome).HasColumnName("nome");
            this.Property(t => t.Email).HasColumnName("email");
            this.Property(t => t.Telefone).HasColumnName("telefone");

        }
    }
}