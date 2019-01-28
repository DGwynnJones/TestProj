using System;

namespace TestProj.EFCodeFirst.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<TestProj.EFCodeFirst.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            if (Environment.MachineName == "L302088")
            {
                AutomaticMigrationDataLossAllowed = true;
            }
        }

        protected override void Seed(TestProj.EFCodeFirst.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
