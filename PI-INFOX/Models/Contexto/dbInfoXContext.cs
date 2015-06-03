using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
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

        public DbSet<basAluno> Alunos { get; set; }
        public DbSet<basAviso> Avisos { get; set; }
        public DbSet<basDisciplina> Disciplinas { get; set; }
        public DbSet<basInstituicao> Instituicoes { get; set; }
        public DbSet<basMaterial> Materiais { get; set; }
        public DbSet<basForum> MensagemForums { get; set; }
        public DbSet<basProfessor> Professores { get; set; }
        public DbSet<basVaga_Estagio_Emprego> Vaga_Estagio_Emprego { get; set; }
        public DbSet<basUsuario> Usuarios { get; set; }
        public DbSet<basContato> Contatos { get; set; }
       

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
    }
}