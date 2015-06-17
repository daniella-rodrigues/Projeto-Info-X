using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using PI_INFOX.Models.Basicas;


namespace PI_INFOX.Models.Mapping
{
    public class Vaga_Estagio_EmpregoMap : EntityTypeConfiguration<basVaga_Estagio_Emprego>
    {
       public Vaga_Estagio_EmpregoMap()
        {
            // Primary Key
            this.HasKey(t => t.VagaID);

            // Properties
            this.Property(t => t.VagaID)
                 .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.nomeVaga)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.cargo)
                .IsRequired()
                .HasMaxLength(255);
                      
           this.Property(t => t.nomeEmpresa)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Vaga_Estagio_Emprego");
            this.Property(t => t.nomeVaga).HasColumnName("nomeVaga");
            this.Property(t => t.cargo).HasColumnName("cargo");
            this.Property(t => t.horarioEntrada).HasColumnName("horarioEntrada");
            this.Property(t => t.horarioSaida).HasColumnName("horarioSaida");
            this.Property(t => t.VagaID).HasColumnName("idVaga");
            this.Property(t => t.salario).HasColumnName("salario");
            this.Property(t => t.nomeEmpresa).HasColumnName("nomeEmpresa");
            this.Property(t => t.matriculaInstituicaoID).HasColumnName("matriculaInstituicao");
        }
    }
}