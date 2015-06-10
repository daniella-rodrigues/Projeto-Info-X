namespace PI_INFOX.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PI_INFOX.Models.Basicas.dbInfoXContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PI_INFOX.Models.Basicas.dbInfoXContext context)
        {
            
        }
    }
}
