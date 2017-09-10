namespace NIPQuest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NIPQuest.DAL.CompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NIPQuest.DAL.CompanyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.CompanyTable.AddOrUpdate(
                  new Models.Company() { CompanyId = 1, NIP = "7777777777", Name = "MSR TRAFFIC sp. z o.o.", Street = "Kamienna", Number = 7, PostCode = "23-342", City = "Wysogotowo" },
                  new Models.Company() { CompanyId = 2, NIP = "8887777777", Name = "Alma S.A.", Street = "Hodowlana", Number = 5, PostCode = "61-680", City = "Poznañ" },
                  new Models.Company() { CompanyId = 3, NIP = "2227777777", Name = "Budikom", Street = "Czechos³owacka", Number = 16, PostCode = "60-101", City = "Poznañ" });

            context.LogInfoTable.AddOrUpdate(
                       new Models.LogInfo() { LogId = 1, NumberNIP = "4377777777" });
        }
    }
}
