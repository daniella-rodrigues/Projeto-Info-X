
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using PI_INFOX.Models.Basicas;

namespace PI_INFOX.Models.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<basUsuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.login)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.senha)
                .IsRequired()
                .HasMaxLength(25);
            this.Property(t => t.confirmaSenha)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.lembreteSenha)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.confirmaSenha)
               .IsRequired()
               .HasMaxLength(20);

            this.Property(t => t.email)
               .IsRequired()
               .HasMaxLength(30);

            this.Property(t => t.confirmaEmail)
               .IsRequired()
               .HasMaxLength(30);

            this.Property(t => t.telefone)
               .IsRequired()
               .HasMaxLength(30);

            this.Property(t => t.tipoUser)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.matricula)
               .IsOptional()
               .HasMaxLength(30);

            this.Property(t => t.nome)
               .IsOptional()
               .HasMaxLength(60);

            this.Property(t => t.Instituicao)
               .IsOptional()
               .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.UserID).HasColumnName("Id");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.senha).HasColumnName("senha");
            this.Property(t => t.lembreteSenha).HasColumnName("lembreteSenha");
            this.Property(t => t.respostaSenha).HasColumnName("respostaSenha");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.dataNascimento).HasColumnName("dataNascimento");
            this.Property(t => t.telefone).HasColumnName("telefone");
            this.Property(t => t.tipoUser).HasColumnName("tipoUser");
            this.Property(t => t.matricula).HasColumnName("matricula");
            this.Property(t => t.nome).HasColumnName("nome");
            this.Property(t => t.Instituicao).HasColumnName("instituicao");

          
            
          
        }

    }
}