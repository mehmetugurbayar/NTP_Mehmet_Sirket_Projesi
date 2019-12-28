namespace CFDAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CFDAL.SirketContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; //otomatik olarak verileri veritabanına göndermek için
            AutomaticMigrationDataLossAllowed = true;  
        }

        protected override void Seed(CFDAL.SirketContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
