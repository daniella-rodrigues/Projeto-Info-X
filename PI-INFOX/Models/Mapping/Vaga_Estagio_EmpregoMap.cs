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

            this.Property(t => t.tipoVaga)
               .IsRequired()
               .HasMaxLength(255);

            this.Property(t => t.cargo)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.requesito)
                 .IsRequired()
                 .HasMaxLength(255);

            this.Property(t => t.exp)
                 .IsRequired()
                 .HasMaxLength(255);
            this.Property(t => t.formacao)
                 .IsRequired()
                 .HasMaxLength(255);

            this.Property(t => t.local)
                 .IsRequired()
                 .HasMaxLength(255);

            this.Property(t => t.salario)
                 .IsRequired();
                 
            this.Property(t => t.horario)
                 .IsRequired()
                 .HasMaxLength(255);
                      
           this.Property(t => t.nomeEmpresa)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Vagas");
            this.Property(t => t.VagaID).HasColumnName("idVaga");
            this.Property(t => t.nomeVaga).HasColumnName("nomeVaga");
            this.Property(t => t.tipoVaga).HasColumnName("tipovaga");
            this.Property(t => t.cargo).HasColumnName("cargo");
            this.Property(t => t.requesito).HasColumnName("requisito");
            this.Property(t => t.exp).HasColumnName("experiencia");
            this.Property(t => t.formacao).HasColumnName("formacao");
            this.Property(t => t.local).HasColumnName("local");        
            this.Property(t => t.salario).HasColumnName("salario");
            this.Property(t => t.horario).HasColumnName("horario");
            this.Property(t => t.nomeEmpresa).HasColumnName("nomeEmpresa");
            
        }
    }
}