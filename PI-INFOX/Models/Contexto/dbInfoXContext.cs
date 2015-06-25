using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using PI_INFOX.Models.Mapping;


namespace PI_INFOX.Models.Basicas
{
    public class dbInfoXContext: DbContext
    {
        static dbInfoXContext()
        {
            Database.SetInitializer<dbInfoXContext>(null);
        }
        public dbInfoXContext()
            : base("Name=dbInfoXContext")
        { 
        }

        public DbSet<basAluno> Aluno { get; set; }
        public DbSet<basAviso> Aviso { get; set; }
        public DbSet<basDisciplina> Disciplina { get; set; }
        public DbSet<basInstituicao> Instituicao { get; set; }
        public DbSet<basMaterial> Material { get; set; }
        public DbSet<basForum> Forum { get; set; }
        public DbSet<basProfessor> Professor { get; set; }
        public DbSet<basVaga_Estagio_Emprego> Vagas { get; set; }
        public DbSet<basUsuario> Usuario { get; set; }
        public DbSet<basContato> contato { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new AlunoMap());
            modelBuilder.Configurations.Add(new AvisoMap());
            modelBuilder.Configurations.Add(new DisciplinaMap());
            modelBuilder.Configurations.Add(new InstituicaoMap());
            modelBuilder.Configurations.Add(new MaterialMap());
            modelBuilder.Configurations.Add(new ForumMap());
            modelBuilder.Configurations.Add(new ProfessorMap());
            modelBuilder.Configurations.Add(new Vaga_Estagio_EmpregoMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new ContatoMap());
          
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                    
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                  

                }
            }

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("tipoUser") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    if (entry.Property("tipoUser").CurrentValue == null ) { 
                    entry.Property("tipoUser").CurrentValue = "Aluno";
                    }
                }

                if (entry.State == EntityState.Modified)
                {
                   
                    entry.Property("tipoUser").IsModified = false;

                }
            }
            return base.SaveChanges();
        }
    }
}